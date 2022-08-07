using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            _campaignService.Add(campaign);
            _campaignService.Sum(campaign, game);
            Console.WriteLine("{0}, {1} kampanyası kapsamında {2} adlı oyunu %50 indirimle satın almıştır. İndirimli Fiyat: {3} TL", gamer.FirstName, campaign.CampaignName, game.GameName, game.GamePrice);
        }

    }
}
