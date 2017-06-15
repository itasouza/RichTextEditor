using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Web.RichTextEditor.Models
{
    public class RichTextEditorViewModel
    {
        [AllowHtml]
        [Display(Name = "Mensagem:")]
        public string Message {get;set;}

    }
}