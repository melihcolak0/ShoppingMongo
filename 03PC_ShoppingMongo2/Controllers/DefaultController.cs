using _03PC_ShoppingMongo2.Models;
using _03PC_ShoppingMongo2.Services.ProductServices;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Xml.Linq;

namespace _03PC_ShoppingMongo2.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IProductService _productService;

        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DetailComponent(string id)
        {
            return ViewComponent("_UIProductDetailComponent", new { id = id });
        }

        [HttpGet]
        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult _FooterPartial(AdminMailViewModel model)
        {
            model.Subject = "Coza Store | Haber Bülteni Aboneliğiniz Onaylandı";

            var discountRate = "COZA20";
            model.DiscountCoupon = discountRate;

            model.Message = $"Merhaba,\n\nCoza Store'un özel kampanyalarından ve en yeni ürünlerinden haberdar olmanız için haber bültenimize başarıyla abone oldunuz.\n\n🎁 Size özel bir indirim kuponumuz var!\n\nKupon Kodu: {model.DiscountCoupon}\nİndirim: %20\nGeçerlilik: Tüm ürünlerde\n\nKuponunuzu hemen kullanarak alışverişin keyfini çıkarın! 👉 https://www.cozastore.com\n\nEğer herhangi bir sorunuz varsa, bizimle iletişime geçmekten çekinmeyin.\n\nKeyifli alışverişler dileriz!\n\nSevgilerle,\nCoza Store Ekibi";
        
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Coza Store Admin", "projectsdotnet1@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            client.Authenticate("projectsdotnet1@gmail.com", "my_mail_key");
            client.Send(mimeMessage);
            client.Disconnect(true);           

            return RedirectToAction("Index");
        }
    }
}
