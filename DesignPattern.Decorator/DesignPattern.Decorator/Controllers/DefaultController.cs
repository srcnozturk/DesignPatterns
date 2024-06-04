using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Decorator.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            createNewMessage.SendMessage(message);
            return View();
        }

        [HttpGet]
        public IActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index2(Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            EncrypttoBySubjectDecorator encrypttoBySubjectDecorator = new EncrypttoBySubjectDecorator(createNewMessage);
            encrypttoBySubjectDecorator.SendMessageEncryptoSubject(message);
            return View();
        }
        [HttpGet]
        public IActionResult Index3()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index3(Message message)
        {
            CreateNewMessage createNewMessage = new CreateNewMessage();
            SubjectIDDecorator subjecIDdecorator = new SubjectIDDecorator(createNewMessage);
            subjecIDdecorator.SendMessageIDSubject(message);
            return View();
        }

    }
}
