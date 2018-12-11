﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace stappBackend.Models.ViewModels.Promotion
{
    public class ModifyPromotionViewModel
    {
        public string Name { get; set; }

        public string Message { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [DataType(DataType.Upload)]
        public IFormCollection Images { set; get; }

        [DataType(DataType.Upload)]
        public IFormCollection Attachments { set; get; }
    }
}
