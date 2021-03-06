﻿using System.Linq;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModel;

namespace WebApplication3.Controllers
{
    public class GigController : Controller
    {
        private ApplicationDbContext _context;


        public GigController()
        {
            _context = new ApplicationDbContext();
        }

        private void ConfigureViewModel(GigViewModel viewModel)
        {
            // Populate companies always
            viewModel.MusicTypes = _context.MusicTypes.Select(x => new SelectListItem
            {
                Text = x.MusicTypeName,
                Value = x.MusicTypeId.ToString()
            });

            viewModel.Instruments = _context.Instruments.Select(x => new SelectListItem
            {
                Text = x.InstrumentName,
                Value = x.InstrumentId.ToString()
            });
            // Populate cover letters only if a company has been selected
            // i.e. if your editing and existing Referral, or if you return the view in the POST method
            if (viewModel.MusicTypeId.HasValue)
            {
                viewModel.Instruments = _context.Instruments.Where(x => x.MusicTypeId == viewModel.MusicTypeId.Value).Select(x => new SelectListItem
                {
                    Text = x.InstrumentName,
                    Value = x.InstrumentId.ToString()
                });
            }
            else
            {
                viewModel.Instruments = new SelectList(Enumerable.Empty<SelectListItem>());
            }
        }

        public ActionResult Create()
        {
            GigViewModel viewModel = new GigViewModel();
            ConfigureViewModel(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(GigViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                // Now you can compare directly w/o having separate enums and no need for casting also.

                if (viewModel.MusicTypeId == MusicType.Blues)
                {

                }
                // check if new gig or needs to be updaated

                var gig = _context.Gigs.Where(g => g.GigName == viewModel.GigName).SingleOrDefault();

                if (gig != null)
                {
                    // updatre the gvlaues
                    gig.GigName = "pappu8";
                }
                else
                {
                    gig = new Gig
                    {
                        GigName = viewModel.GigName,
                        InstrumentId = viewModel.InstrumentId
                    };
                }


                if (viewModel.MusicTypeId.HasValue)
                {
                    gig.MusicTypeId = viewModel.MusicTypeId.Value;

                }
                _context.Gigs.Add(gig);
                _context.SaveChanges();
                return RedirectToAction("Create");
            }
            return RedirectToAction("Create");
        }

        [HttpPost]
        public JsonResult GetInstrumentJson(int musicTypeId)
        {
            //var instruments = _context.Instruments
            //    .Where(c => c.MusicTypeId == musicTypeId)
            //    .ToList();

            //var dropdown = new List<SelectListItem>();
            //foreach (var cl in instruments)
            //{
            //    dropdown.Add(new SelectListItem { Text = cl.InstrumentName, Value = cl.InstrumentId.ToString() });
            //}


            var instruments = _context.Instruments
                .Where(c => c.MusicTypeId == musicTypeId).Select(x => new
                {
                    Value = x.InstrumentId,
                    Text = x.InstrumentName
                });

            return Json(instruments);
        }
    }
}



// How to get SQL Script of the Migrations

// RUn this command----  update-database -script -SourceMigration:"First Migration Name here" (no quotes) 

