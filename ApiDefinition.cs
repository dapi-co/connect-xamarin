using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{


	// @interface DPCConfigurations : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCConfigurations
	{
		// @property (copy, nonatomic) DPCAppEnvironment _Nonnull environment;
		[Export("environment")]
		string Environment { get; set; }

		// @property (nonatomic, strong) NSURLComponents * _Nonnull baseUrl;
		[Export("baseUrl", ArgumentSemantic.Strong)]
		NSUrlComponents BaseUrl { get; set; }

		// @property (copy, nonatomic) NSDictionary<DPCEndPoint,NSString *> * _Nonnull endpoints;
		[Export("endpoints", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Endpoints { get; set; }

		// @property (copy, nonatomic) DPCColorScheme _Nonnull colorScheme;
		[Export("colorScheme")]
		string ColorScheme { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull countries;
		[Export("countries", ArgumentSemantic.Copy)]
		string[] Countries { get; set; }

		// @property (assign, nonatomic) BOOL includeExperimentalBanks;
		[Export("includeExperimentalBanks")]
		bool IncludeExperimentalBanks { get; set; }
	}
	
	// @interface DPCConnectionSubaccountDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCConnectionSubaccountDetails
	{
		// @property (copy, nonatomic) NSString * _Nonnull accountID;
		[Export("accountID")]
		string AccountID { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull accountNumber;
		[Export("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull currencyCode;
		[Export("currencyCode")]
		string CurrencyCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; set; }
	}
	
	// @interface DPCConnectionDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCConnectionDetails
	{
		// @property (copy, nonatomic) NSString * _Nullable bankID;
		[NullAllowed, Export("bankID")]
		string BankID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export("bankName")]
		string BankName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryName;
		[NullAllowed, Export("countryName")]
		string CountryName { get; set; }

		// @property (copy, nonatomic) NSArray<DPCConnectionSubaccountDetails *> * _Nonnull subaccountsDetails;
		[Export("subaccountsDetails", ArgumentSemantic.Copy)]
		DPCConnectionSubaccountDetails[] SubaccountsDetails { get; set; }

		// @property (assign) double beneficiaryCoolDownPeriod;
		[Export("beneficiaryCoolDownPeriod")]
		double BeneficiaryCoolDownPeriod { get; set; }

		// @property (assign) BOOL isCreateBeneficiaryEndpointRequired;
		[Export("isCreateBeneficiaryEndpointRequired")]
		bool IsCreateBeneficiaryEndpointRequired { get; set; }
	}

	// @interface DPCApp : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface DPCApp
	{
		// @property (readonly, nonatomic, class) NSArray<NSString *> * _Nonnull accessIDs;
		[Static]
		[Export("accessIDs")]
		string[] AccessIDs { get; }

		// @property (nonatomic, strong, class) DPCConfigurations * _Nonnull configurations;
		[Static]
		[Export("configurations", ArgumentSemantic.Strong)]
		DPCConfigurations Configurations { get; set; }

		// +(void)setAppKey:(NSString * _Nonnull)appKey configurations:(DPCConfigurations * _Nonnull)configurations;
		[Static]
		[Export("setAppKey:configurations:")]
		void SetAppKey(string appKey, DPCConfigurations configurations);

		// +(void)setUserID:(NSString * _Nonnull)userID;
		[Static]
		[Export("setUserID:")]
		void SetUserID(string userID);

		// +(DPCConnectionDetails * _Nonnull)connectionDetailsWithAccessID:(NSString * _Nonnull)accessID;
		[Static]
		[Export("connectionDetailsWithAccessID:")]
		DPCConnectionDetails ConnectionDetailsWithAccessID(string accessID);
	}

	// @interface DPCBeneficiaryInfo : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCBeneficiaryInfo
	{
		// @property (nonatomic, strong) DPCLinesAddress * _Nullable linesAddress;
		[NullAllowed, Export("linesAddress", ArgumentSemantic.Strong)]
		DPCLinesAddress LinesAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountNumber;
		[NullAllowed, Export("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export("bankName")]
		string BankName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable swiftCode;
		[NullAllowed, Export("swiftCode")]
		string SwiftCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sendingSwiftCode;
		[NullAllowed, Export("sendingSwiftCode")]
		string SendingSwiftCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable iban;
		[NullAllowed, Export("iban")]
		string Iban { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phoneNumber;
		[NullAllowed, Export("phoneNumber")]
		string PhoneNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sendingCountry;
		[NullAllowed, Export("sendingCountry")]
		string SendingCountry { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branchAddress;
		[NullAllowed, Export("branchAddress")]
		string BranchAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branchName;
		[NullAllowed, Export("branchName")]
		string BranchName { get; set; }
	}

	// @interface DPCLinesAddress : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCLinesAddress
	{
		// @property (copy, nonatomic) NSString * _Nonnull line1;
		[Export("line1")]
		string Line1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull line2;
		[Export("line2")]
		string Line2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull line3;
		[Export("line3")]
		string Line3 { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @protocol DPCConnectDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface DPCConnectDelegate
	{
		// @required -(void)connectDidSuccessfullyConnectToBankWithId:(NSString * _Nonnull)bankId accessID:(NSString * _Nonnull)accessID;
		[Abstract]
		[Export("connectDidSuccessfullyConnectToBankWithId:accessID:")]
		void ConnectDidSuccessfullyConnectToBankWithId(string bankId, string accessID);

		// @required -(void)connectDidFailConnectingToBank:(NSString * _Nonnull)bankID withError:(NSString * _Nonnull)error;
		[Abstract]
		[Export("connectDidFailConnectingToBank:withError:")]
		void ConnectDidFailConnectingToBank(string bankID, string error);

		// @required -(DPCBeneficiaryInfo * _Nullable)connectBeneficiaryInfoForBankWithId:(NSString * _Nonnull)bankId;
		[Abstract]
		[Export("connectBeneficiaryInfoForBankWithId:")]
		[return: NullAllowed]
		DPCBeneficiaryInfo ConnectBeneficiaryInfoForBankWithId(string bankId);

		// @optional -(void)connectDidProceedSuccessfulConnection;
		[Export("connectDidProceedSuccessfulConnection")]
		void ConnectDidProceedSuccessfulConnection();

		// @optional -(void)connectDidRetryFailedConnection;
		[Export("connectDidRetryFailedConnection")]
		void ConnectDidRetryFailedConnection();
	}

	// @interface DPCConnect : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCConnect
	{
		[Wrap("WeakConnectDelegate")]
		[NullAllowed]
		DPCConnectDelegate ConnectDelegate { get; set; }

		// @property (nonatomic, weak) id<DPCConnectDelegate> _Nullable connectDelegate;
		[NullAllowed, Export("connectDelegate", ArgumentSemantic.Weak)]
		NSObject WeakConnectDelegate { get; set; }

		// -(void)present;
		[Export("present")]
		void Present();

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export("dismissWithCompletion:")]
		void DismissWithCompletion([NullAllowed] Action completion);
	}

	// @interface DPCNumber : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCNumber
	{
		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export("value")]
		string Value { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCAddress : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCAddress
	{
		// @property (copy, nonatomic) NSString * _Nonnull flat;
		[Export("flat")]
		string Flat { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull building;
		[Export("building")]
		string Building { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull area;
		[Export("area")]
		string Area { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull poBox;
		[Export("poBox")]
		string PoBox { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull city;
		[Export("city")]
		string City { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull state;
		[Export("state")]
		string State { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull country;
		[Export("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull full;
		[Export("full")]
		string Full { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCIdentification : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCIdentification
	{
		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export("value")]
		string Value { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}
	
	// @interface DPCIdentity : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCIdentity
	{
		// @property (copy, nonatomic) NSString * _Nonnull nationality;
		[Export("nationality")]
		string Nationality { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull dateOfBirth;
		[Export("dateOfBirth")]
		string DateOfBirth { get; set; }

		// @property (copy, nonatomic) NSArray<DPCNumber *> * _Nonnull numbers;
		[Export("numbers", ArgumentSemantic.Copy)]
		DPCNumber[] Numbers { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull emailAddress;
		[Export("emailAddress")]
		string EmailAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) DPCAddress * _Nonnull address;
		[Export("address", ArgumentSemantic.Strong)]
		DPCAddress Address { get; set; }

		// @property (copy, nonatomic) NSArray<DPCIdentification *> * _Nonnull identifications;
		[Export("identifications", ArgumentSemantic.Copy)]
		DPCIdentification[] Identifications { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCAccount : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCAccount
	{
		// @property (nonatomic, strong) NSString * _Nonnull iban;
		[Export("iban", ArgumentSemantic.Strong)]
		string Iban { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull number;
		[Export("number", ArgumentSemantic.Strong)]
		string Number { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull currency;
		[Export("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull type;
		[Export("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull accountID;
		[Export("accountID", ArgumentSemantic.Strong)]
		string AccountID { get; set; }

		// @property (assign, nonatomic) BOOL isFavourite;
		[Export("isFavourite")]
		bool IsFavourite { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCPair : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCPair
	{
		// @property (nonatomic, strong) NSString * _Nonnull code;
		[Export("code", ArgumentSemantic.Strong)]
		string Code { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCBalance : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCBalance
	{
		// @property (nonatomic, strong) NSNumber * _Nonnull amount;
		[Export("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; set; }

		// @property (nonatomic, strong) DPCPair * _Nonnull currency;
		[Export("currency", ArgumentSemantic.Strong)]
		DPCPair Currency { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull accountNumber;
		[Export("accountNumber", ArgumentSemantic.Strong)]
		string AccountNumber { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCTransaction : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCTransaction
	{
		// @property (nonatomic, strong) NSNumber * _Nonnull beforeAmount;
		[Export("beforeAmount", ArgumentSemantic.Strong)]
		NSNumber BeforeAmount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull afterAmount;
		[Export("afterAmount", ArgumentSemantic.Strong)]
		NSNumber AfterAmount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull amount;
		[Export("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; set; }

		// @property (nonatomic, strong) DPCPair * _Nonnull currency;
		[Export("currency", ArgumentSemantic.Strong)]
		DPCPair Currency { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull date;
		[Export("date", ArgumentSemantic.Strong)]
		NSDate Date { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull transactionDescription;
		[Export("transactionDescription")]
		string TransactionDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable details;
		[NullAllowed, Export("details")]
		string Details { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export("type")]
		string Type { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCResult : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCResult
	{
		// @property (copy, nonatomic) NSString * _Nonnull jobID;
		[Export("jobID")]
		string JobID { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull status;
		[Export("status")]
		string Status { get; set; }

		// @property (assign, nonatomic) BOOL success;
		[Export("success")]
		bool Success { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull message;
		[Export("message")]
		string Message { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export("initWithDictionary:")]
		IntPtr Constructor(NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCPayment : NSObject
	[BaseType(typeof(NSObject))]
	interface DPCPayment
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull accessID;
		[Export("accessID")]
		string AccessID { get; }

		// -(instancetype _Nullable)initWithAccessID:(NSString * _Nonnull)accessID;
		[Export("initWithAccessID:")]
		IntPtr Constructor(string accessID);

		// -(void)getIdentity:(void (^ _Nullable)(DPCIdentity * _Nullable, NSError * _Nullable))completion;
		[Export("getIdentity:")]
		void GetIdentity([NullAllowed] Action<DPCIdentity, NSError> completion);

		// -(void)getAccounts:(void (^ _Nullable)(NSArray<DPCAccount *> * _Nullable, NSError * _Nullable))completion;
		[Export("getAccounts:")]
		void GetAccounts([NullAllowed] Action<DPCAccount[], NSError> completion);

		// -(void)getBalanceForAccountID:(NSString * _Nonnull)accountID completion:(void (^ _Nullable)(DPCBalance * _Nullable, NSError * _Nullable))completion;
		[Export("getBalanceForAccountID:completion:")]
		void GetBalanceForAccountID(string accountID, [NullAllowed] Action<DPCBalance, NSError> completion);

		// -(void)getTransactionsForAccountID:(NSString * _Nonnull)accountID fromDate:(NSDate * _Nonnull)fromDate toDate:(NSDate * _Nonnull)toDate completion:(void (^ _Nullable)(NSArray<DPCTransaction *> * _Nullable, NSError * _Nullable))completion;
		[Export("getTransactionsForAccountID:fromDate:toDate:completion:")]
		void GetTransactionsForAccountID(string accountID, NSDate fromDate, NSDate toDate, [NullAllowed] Action<DPCTransaction[], NSError> completion);

		// -(void)delinkUserCompletion:(void (^ _Nullable)(DPCResult * _Nullable, NSError * _Nullable))completion;
		[Export("delinkUserCompletion:")]
		void DelinkUserCompletion([NullAllowed] Action<DPCResult, NSError> completion);
	}

}
