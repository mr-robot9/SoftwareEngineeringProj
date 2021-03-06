﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CodingBlogDemo2.Models;

namespace CodingBlogDemo2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Register> Registers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MultipleChoice> MultipleChoices { get; set; }
        public DbSet<CodeSnippet> CodeSnippets { get; set; }
        public DbSet<CodeSnippetNoAnswer> CodeSnippetNoAnswers { get; set; }
        public DbSet<MultipleChoiceSubmission> MultipleChoiceSubmissions { get; set; }
        public DbSet<CodeSnippetSubmission> CodeSnippetSubmissions { get; set; }
        public DbSet<CodeSnippetNoAnswerSubmission> CodeSnippetNoAnswerSubmissions { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<Folder> Folders { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

    }
}