using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiceBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {




        [Command("Test")]
        public async Task _Test(IGuildUser user)
        {
            await Context.Channel.SendMessageAsync(string.Format("{0} sucks massive dicks", user.Mention));
        }
        
        [Command("55x2")]
        public async Task _55x2(string amountstr, IGuildUser challenged)
        {
            var builder = new EmbedBuilder()
                .WithTitle("You just rolled the dice")
                .WithUrl("https://discordapp.com/")
                .WithColor(new Color(0xFF0000))
                .WithThumbnailUrl("https://images-ext-1.discordapp.net/external/nfLZgVKBez0p9uhGzlPwIQWGVhfvqF-7jfEkoAJI_-Q/%3Fcb%3D20111120013858/https/vignette.wikia.nocookie.net/runescape2/images/f/f2/Dice_bag_detail.png/revision/latest");

            int amountint = Convert.ToInt16(amountstr.Trim('k', 'm', 'K', 'M'));
            string multiplier = "";

            if (amountstr.Contains("k") || amountstr.Contains("k"))
            {
                multiplier = "K";
            }
            else if (amountstr.Contains("m") || amountstr.Contains("K"))
            {
                multiplier = "m";
            }

            Random r = new Random();
            double randomValue = 0 + (100 - 0) * r.NextDouble();

            if (randomValue >= 55)
            {
                builder.AddField("The roll was:", Math.Round(randomValue, 2))
                        .AddField("The winner is:", challenged.Mention)
                        .AddField("With an amount of:", amountint * 2 + multiplier);
                var embed = builder.Build();
                await Context.Channel.SendMessageAsync("", false, embed);
            }
            else
            {
                builder.AddField("The roll was:", Math.Round(randomValue, 2))
                        .AddField("The winner is:", Context.User.Mention)
                        .AddField("With an amount of:", amountint + multiplier);
                var embed = builder.Build();
                await Context.Channel.SendMessageAsync("", false, embed);
            }
        }

        [Command("78x3")]
        public async Task _78x3(IGuildUser challenged)
        {
            Random r = new Random();
            double randomValue = 0 + (100 - 0) * r.NextDouble();

            if (randomValue >= 78)
            {
                await Context.Channel.SendMessageAsync("The score was: " + Math.Round(randomValue, 2) + " : " + challenged.Mention + " wins");
            }
            else
            {
                await Context.Channel.SendMessageAsync("The score was: " + Math.Round(randomValue, 2) + " : " + Context.User.Mention + " wins");
            }
        }

        [Command("95x5")]
        public async Task _95x5(IGuildUser challenged)
        {
            Random r = new Random();
            double randomValue = 0 + (100 - 0) * r.NextDouble();

            if (randomValue >= 95)
            {
                await Context.Channel.SendMessageAsync("The score was: " + Math.Round(randomValue, 2) + " : " + challenged.Mention + " wins");
            }
            else
            {
                await Context.Channel.SendMessageAsync("The score was: " + Math.Round(randomValue, 2) + " : " + Context.User.Mention + " wins");
            }
        }
    }
}
