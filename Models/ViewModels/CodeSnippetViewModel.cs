﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodingBlogDemo2.Models.ViewModels
{
    public class CodeSnippetViewModel
    {
        public int PostId { get; set; }
        public int CategoryType { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Description/Question")]
        public String Description { get; set; }

        [Required]
        [Display(Name = "Code Snippet")]
        public String Code { get; set; }

        [Required]
        public String Answer { get; set; }
    }
}
