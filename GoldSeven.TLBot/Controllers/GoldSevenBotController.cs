using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using Telegram.Bot.Types.Enums;

namespace GoldSeven.TLBot.Controllers
{
    public class GoldSevenBotController : ApiController
    {
        Telegram.Bot.TelegramBotClient bot;
        //public GoldSevenBot()
        //{
        //    bot = new Telegram.Bot.TelegramBotClient("323@#@");
        //}
        //public string v()
        //{
        //    FontFamily fontFamily = new FontFamily("Tahoma");
        //    Font font = new Font(
        //       fontFamily,
        //       16,
        //       FontStyle.Regular,
        //       GraphicsUnit.Pixel);

        //    Label lab = new Label();
        //    lab.Text = "Font Bold at 24";
        //    //lab.Font = new Font("Arial", 20);

        //    bot.SendTextMessageAsync(87689, lab, ParseMode.Default, false, false, 0);
        //}
    }
}
