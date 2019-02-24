using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyDevLab.ViewModels.WebPush;

namespace MyDevLab.Controllers
{
    [Authorize]
    public class WebPushController : Controller
    {
        private const string VIEW_MODELS_PATH = "~/Views/WebPush/";
        private const string CSHTML_EXT = ".cshtml";


        [HttpGet]
        public IActionResult Wizard()
        {
            return View($"{VIEW_MODELS_PATH}WizardIndex{CSHTML_EXT}");
        }

        [HttpGet]
        public IActionResult Statistics()
        {
            return View($"{VIEW_MODELS_PATH}StatisticsIndex{CSHTML_EXT}");
        }

        [HttpGet]
        public IActionResult LivePreview()
        {
            var livePreview = new LivePreviewVM()
            {
                Subject = "Test Web Push Subject",
                BigImageImg = "..\\images\\WebPush\\LivePreview\\grumpyCat.jpg",
                Body = "Test body content",
                IconImg = "..\\images\\WebPush\\LivePreview\\grumpyCatIcon.png",
                IsAction1Selected = true,
                Action1IconImg = "..\\images\\WebPush\\LivePreview\\yes.png",
                Action1Title = "Action 1 Test",
                IsAction2Selected = true,
                Action2IconImg = "..\\images\\WebPush\\LivePreview\\no.png",
                Action2Title = "Action 2 Test"
            };

            return View($"{VIEW_MODELS_PATH}LivePreview{CSHTML_EXT}", livePreview);
        }
    }
}
