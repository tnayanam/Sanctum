﻿using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class DropDownViewModel
    {

        public DropDownViewModel()
        {
            SongList = new List<SelectListItem>();
        }

        public int Id { get; set; }

        public List<SelectListItem> SongList { get; set; }
    }
}