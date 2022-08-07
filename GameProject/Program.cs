using GameProject;

Gamer gamer1 = new Gamer { Id = 1, BirthYear = 1999, FirstName = "İLKER FURKAN", LastName = "ŞAHİN", IdentityNumber = 12345678910 };
GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(gamer1);

//GameManager gameManager = new GameManager();
Game game1 = new Game { Id = 1, GameName = "FIFA 22", GamePrice = 400 };

//CampaignManager campaignManager = new CampaignManager();
Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Steam Yaz İndirimleri", Discount = 0.5 };

OrderManager orderManager = new OrderManager(new CampaignManager());
orderManager.Sale(game1, gamer1, campaign1);

