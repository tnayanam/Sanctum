﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PlutoDbContext : DbContext
    {
        public PlutoDbContext()
            : base("name=PlutoDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSection> CourseSections { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
    
        public virtual int DeleteCourse(Nullable<int> courseID)
        {
            var courseIDParameter = courseID.HasValue ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteCourse", courseIDParameter);
        }
    
        [DbFunction("PlutoDbContext", "funcGetAuthorCourses")]
        public virtual IQueryable<funcGetAuthorCourses_Result> funcGetAuthorCourses(Nullable<int> authorID)
        {
            var authorIDParameter = authorID.HasValue ?
                new ObjectParameter("AuthorID", authorID) :
                new ObjectParameter("AuthorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<funcGetAuthorCourses_Result>("[PlutoDbContext].[funcGetAuthorCourses](@AuthorID)", authorIDParameter);
        }
    
        public virtual ObjectResult<Course> GetCourses()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourses");
        }
    
        public virtual ObjectResult<Course> GetCourses(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Course>("GetCourses", mergeOption);
        }
    
        public virtual int InsertCourse(Nullable<int> authorID, string title, string description, Nullable<short> price, string levelString, Nullable<byte> level)
        {
            var authorIDParameter = authorID.HasValue ?
                new ObjectParameter("AuthorID", authorID) :
                new ObjectParameter("AuthorID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(short));
    
            var levelStringParameter = levelString != null ?
                new ObjectParameter("LevelString", levelString) :
                new ObjectParameter("LevelString", typeof(string));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertCourse", authorIDParameter, titleParameter, descriptionParameter, priceParameter, levelStringParameter, levelParameter);
        }
    
        public virtual int UpdateCourse(Nullable<int> courseID, string title, string description, string levelString, Nullable<byte> level)
        {
            var courseIDParameter = courseID.HasValue ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var levelStringParameter = levelString != null ?
                new ObjectParameter("LevelString", levelString) :
                new ObjectParameter("LevelString", typeof(string));
    
            var levelParameter = level.HasValue ?
                new ObjectParameter("Level", level) :
                new ObjectParameter("Level", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateCourse", courseIDParameter, titleParameter, descriptionParameter, levelStringParameter, levelParameter);
        }
    }
}
