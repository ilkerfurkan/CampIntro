using OOP3;
using System.Collections.Generic;

ICreditManager consumerLoanManager = new ConsumerLoanManager();
ICreditManager vehicleLoanManager = new VehicleLoanManager();
ICreditManager housingLoanManager = new HousingLoanManager();

//ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

AppealManager appealManager = new AppealManager();
appealManager.MakeAnAppeal(vehicleLoanManager, loggers);

List<ICreditManager> credits = new List<ICreditManager>() {consumerLoanManager,vehicleLoanManager};
//appealManager.MakeALoanPreInfo(credits);

// bu yapılanlar yazılımda sürdürülebilirliği sağlar.

// interface gerçek hayatta tam olarak bu amaçla kullanılır. Kodlarda boğulmayı(kod kalabalığını) engeller.
