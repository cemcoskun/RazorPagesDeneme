using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDeneme.Pages
{
    public class CemModel : PageModel
    {
        public string Sonuc { get; set; }
        public string GozRengi { get; set; }
        [BindProperty]
        public Quiz quiz { get; set; }
        public void OnGet(bool? dogruMu)
        {
            ViewData["Deneme"] = "ViewData Deniyorum";

            GozRengi = "Gri";

            if (dogruMu.HasValue)
            {
                Sonuc = dogruMu.Value ? "Tebrikler bildiniz." : "Maalesef bilemediniz.";
            }
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            bool result = quiz.Cevap.ToLower() == "şahin";
            return RedirectToPage("./Cem", new { dogruMu = result });
        }
    }

    public class Quiz
    {
        [Required]
        public string Cevap { get; set; }
    }
}