using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LMSweb.Models;
using System.ComponentModel.DataAnnotations;


namespace LMSweb.Models
{
    public class Studentjourney
    {

        [Key]
        [Display(Name = "學生編號")]
        public string SID { get; set; }

        //[Column(Order = 0)]
        [Display(Name = "編號")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "動作類型")]
        public string ActionType { get; set; }

        [Required]
        [Display(Name = "動作子項")]
        public string subAction { get; set; }

        [Required]
        [Display(Name = "動作內容")]
        public string Detail { get; set; }

        public string Time { get; set; }

        public virtual StudentMission StudentMissions { get; set; }

    }
}