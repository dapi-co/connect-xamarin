using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace NativeLibrary
{

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const DPCAppEnvironment _Nonnull DPCAppEnvironmentProduction;
		[Field ("DPCAppEnvironmentProduction", "__Internal")]
		NSString DPCAppEnvironmentProduction { get; }

		// extern const DPCAppEnvironment _Nonnull DPCAppEnvironmentSandbox;
		[Field ("DPCAppEnvironmentSandbox", "__Internal")]
		NSString DPCAppEnvironmentSandbox { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointExchangeToken;
		[Field ("DPCEndPointExchangeToken", "__Internal")]
		NSString DPCEndPointExchangeToken { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointGetIdentity;
		[Field ("DPCEndPointGetIdentity", "__Internal")]
		NSString DPCEndPointGetIdentity { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointGetAccounts;
		[Field ("DPCEndPointGetAccounts", "__Internal")]
		NSString DPCEndPointGetAccounts { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointGetAccountMetadata;
		[Field ("DPCEndPointGetAccountMetadata", "__Internal")]
		NSString DPCEndPointGetAccountMetadata { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointGetBalance;
		[Field ("DPCEndPointGetBalance", "__Internal")]
		NSString DPCEndPointGetBalance { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointGetTransactions;
		[Field ("DPCEndPointGetTransactions", "__Internal")]
		NSString DPCEndPointGetTransactions { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointGetBeneficiaries;
		[Field ("DPCEndPointGetBeneficiaries", "__Internal")]
		NSString DPCEndPointGetBeneficiaries { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointCreateBeneficiary;
		[Field ("DPCEndPointCreateBeneficiary", "__Internal")]
		NSString DPCEndPointCreateBeneficiary { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointCreateTransfer;
		[Field ("DPCEndPointCreateTransfer", "__Internal")]
		NSString DPCEndPointCreateTransfer { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointResumeJob;
		[Field ("DPCEndPointResumeJob", "__Internal")]
		NSString DPCEndPointResumeJob { get; }

		// extern const DPCEndPoint _Nonnull DPCEndPointDelinkUser;
		[Field ("DPCEndPointDelinkUser", "__Internal")]
		NSString DPCEndPointDelinkUser { get; }

		// extern const DPCColorScheme _Nonnull DPCColorSchemeGeneral;
		[Field ("DPCColorSchemeGeneral", "__Internal")]
		NSString DPCColorSchemeGeneral { get; }

		// extern const DPCColorScheme _Nonnull DPCColorSchemeBW;
		[Field ("DPCColorSchemeBW", "__Internal")]
		NSString DPCColorSchemeBW { get; }

		// extern const DPCColorScheme _Nonnull DPCColorSchemeNeon;
		[Field ("DPCColorSchemeNeon", "__Internal")]
		NSString DPCColorSchemeNeon { get; }
	}

	// @interface DPCTransferBound : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCTransferBound
	{
		// @property (nonatomic, strong) NSNumber * _Nonnull minimum;
		[Export ("minimum", ArgumentSemantic.Strong)]
		NSNumber Minimum { get; set; }

		// @property (nonatomic, strong) DPCPair * _Nonnull currency;
		[Export ("currency", ArgumentSemantic.Strong)]
		DPCPair Currency { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCBankMetadata : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCBankMetadata
	{
		// @property (nonatomic, strong) DPCLinesAddress * _Nonnull linesAddress;
		[Export ("linesAddress", ArgumentSemantic.Strong)]
		DPCLinesAddress LinesAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull bankName;
		[Export ("bankName")]
		string BankName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull branchAddress;
		[Export ("branchAddress")]
		string BranchAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull branchName;
		[Export ("branchName")]
		string BranchName { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull swiftCode;
		[Export ("swiftCode")]
		string SwiftCode { get; set; }

		// @property (assign, nonatomic) BOOL isCreateBeneficairyEndpointRequired;
		[Export ("isCreateBeneficairyEndpointRequired")]
		bool IsCreateBeneficairyEndpointRequired { get; set; }

		// @property (assign, nonatomic) NSTimeInterval beneficiaryCoolDownPeriod;
		[Export ("beneficiaryCoolDownPeriod")]
		double BeneficiaryCoolDownPeriod { get; set; }

		// @property (copy, nonatomic) NSArray<DPCTransferBound *> * _Nonnull transferBounds;
		[Export ("transferBounds", ArgumentSemantic.Copy)]
		DPCTransferBound[] TransferBounds { get; set; }

		// @property (nonatomic, strong) DPCPair * _Nonnull country;
		[Export ("country", ArgumentSemantic.Strong)]
		DPCPair Country { get; set; }

		// @property (assign, nonatomic) NSTimeInterval transactionsRetentionPeriod;
		[Export ("transactionsRetentionPeriod")]
		double TransactionsRetentionPeriod { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);

		// -(DPCBeneficiaryInfo * _Nonnull)basicBeneficiaryInfo;
		[Export ("basicBeneficiaryInfo")]
		[Verify (MethodToProperty)]
		DPCBeneficiaryInfo BasicBeneficiaryInfo { get; }
	}
	
	// @interface DPCConfigurations : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DPCConfigurations
	{
		// @property (copy, nonatomic) NSString * _Nonnull appKey;
		[Export ("appKey")]
		string AppKey { get; set; }

		// @property (nonatomic, strong) NSURLComponents * _Nonnull baseUrl;
		[Export ("baseUrl", ArgumentSemantic.Strong)]
		NSUrlComponents BaseUrl { get; set; }

		// @property (copy, nonatomic) NSArray<NSString *> * _Nonnull countries;
		[Export ("countries", ArgumentSemantic.Copy)]
		string[] Countries { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull clientUserID;
		[Export ("clientUserID")]
		string ClientUserID { get; set; }

		// @property (copy, nonatomic) DPCAppEnvironment _Nonnull environment;
		[Export ("environment")]
		string Environment { get; set; }

		// @property (copy, nonatomic) NSDictionary<DPCEndPoint,NSString *> * _Nonnull endpoints;
		[Export ("endpoints", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSString> Endpoints { get; set; }

		// @property (copy, nonatomic) DPCColorScheme _Nonnull colorScheme;
		[Export ("colorScheme")]
		string ColorScheme { get; set; }

		// @property (assign, nonatomic) BOOL isExperimental;
		[Export ("isExperimental")]
		bool IsExperimental { get; set; }

		// @property (copy, nonatomic) NSDictionary<DPCEndPoint,NSArray<NSURLQueryItem *> *> * _Nonnull endPointExtraQueryItems;
		[Export ("endPointExtraQueryItems", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSArray<NSURLQueryItem>> EndPointExtraQueryItems { get; set; }

		// @property (copy, nonatomic) NSDictionary<DPCEndPoint,NSDictionary<NSString *,NSString *> *> * _Nonnull endPointExtraHeaderFields;
		[Export ("endPointExtraHeaderFields", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSDictionary<NSString, NSString>> EndPointExtraHeaderFields { get; set; }

		// @property (copy, nonatomic) NSDictionary<DPCEndPoint,NSDictionary<NSString *,id> *> * _Nonnull endPointExtraBody;
		[Export ("endPointExtraBody", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSDictionary<NSString, NSObject>> EndPointExtraBody { get; set; }

		// -(instancetype _Nonnull)initWithAppKey:(NSString * _Nonnull)appKey baseUrl:(NSURLComponents * _Nonnull)baseUrl countries:(NSArray<NSString *> * _Nonnull)countries clientUserID:(NSString * _Nonnull)clientUserID;
		[Export ("initWithAppKey:baseUrl:countries:clientUserID:")]
		IntPtr Constructor (string appKey, NSUrlComponents baseUrl, string[] countries, string clientUserID);
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
	[BaseType (typeof(NSObject))]
	interface DPCConnectionDetails
	{
		// @property (copy, nonatomic) NSString * _Nullable userID;
		[NullAllowed, Export ("userID")]
		string UserID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable clientUserID;
		[NullAllowed, Export ("clientUserID")]
		string ClientUserID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bankID;
		[NullAllowed, Export ("bankID")]
		string BankID { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export ("bankName")]
		string BankName { get; set; }

		// @property (assign) double beneficiaryCoolDownPeriod;
		[Export ("beneficiaryCoolDownPeriod")]
		double BeneficiaryCoolDownPeriod { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable countryName;
		[NullAllowed, Export ("countryName")]
		string CountryName { get; set; }

		// @property (assign) BOOL isCreateBeneficiaryEndpointRequired;
		[Export ("isCreateBeneficiaryEndpointRequired")]
		bool IsCreateBeneficiaryEndpointRequired { get; set; }

		// @property (copy, nonatomic) NSArray<DPCAccount *> * _Nonnull accounts;
		[Export ("accounts", ArgumentSemantic.Copy)]
		DPCAccount[] Accounts { get; set; }
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
	[BaseType (typeof(NSObject))]
	interface DPCBeneficiaryInfo
	{
		// @property (nonatomic, strong) DPCLinesAddress * _Nullable linesAddress;
		[NullAllowed, Export ("linesAddress", ArgumentSemantic.Strong)]
		DPCLinesAddress LinesAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable accountNumber;
		[NullAllowed, Export ("accountNumber")]
		string AccountNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable name;
		[NullAllowed, Export ("name")]
		string Name { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable bankName;
		[NullAllowed, Export ("bankName")]
		string BankName { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable swiftCode;
		[NullAllowed, Export ("swiftCode")]
		string SwiftCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sendingSwiftCode;
		[NullAllowed, Export ("sendingSwiftCode")]
		string SendingSwiftCode { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable iban;
		[NullAllowed, Export ("iban")]
		string Iban { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable phoneNumber;
		[NullAllowed, Export ("phoneNumber")]
		string PhoneNumber { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable country;
		[NullAllowed, Export ("country")]
		string Country { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable sendingCountry;
		[NullAllowed, Export ("sendingCountry")]
		string SendingCountry { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branchAddress;
		[NullAllowed, Export ("branchAddress")]
		string BranchAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable branchName;
		[NullAllowed, Export ("branchName")]
		string BranchName { get; set; }

		// -(NSDictionary<NSString *,id> * _Nonnull)dictionaryRepresentation;
		[Export ("dictionaryRepresentation")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSObject> DictionaryRepresentation { get; }
	}

	// @interface DPCBeneficiary : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCBeneficiary
	{
		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable accountNumber;
		[NullAllowed, Export ("accountNumber", ArgumentSemantic.Strong)]
		string AccountNumber { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iban;
		[NullAllowed, Export ("iban", ArgumentSemantic.Strong)]
		string Iban { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull type;
		[Export ("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull status;
		[Export ("status", ArgumentSemantic.Strong)]
		string Status { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull accountID;
		[Export ("accountID", ArgumentSemantic.Strong)]
		string AccountID { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCLinesAddress : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCLinesAddress
	{
		// @property (copy, nonatomic) NSString * _Nonnull line1;
		[Export ("line1")]
		string Line1 { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull line2;
		[Export ("line2")]
		string Line2 { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull line3;
		[Export ("line3")]
		string Line3 { get; set; }

		// -(NSDictionary<NSString *,id> * _Nonnull)dicrionaryRepresentation;
		[Export ("dicrionaryRepresentation")]
		[Verify (MethodToProperty)]
		NSDictionary<NSString, NSObject> DicrionaryRepresentation { get; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

		// @protocol DPCAutoFlowDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface DPCAutoFlowDelegate
	{
		// @required -(void)autoFlow:(DPCAutoFlow * _Nonnull)autoFlow beneficiaryInfoForBankWithID:(NSString * _Nonnull)bankID beneficiaryInfo:(void (^ _Nonnull)(DPCBeneficiaryInfo * _Nullable))info;
		[Abstract]
		[Export ("autoFlow:beneficiaryInfoForBankWithID:beneficiaryInfo:")]
		void BeneficiaryInfoForBankWithID (DPCAutoFlow autoFlow, string bankID, Action<DPCBeneficiaryInfo> info);

		// @required -(void)autoFlow:(DPCAutoFlow * _Nonnull)autoFlow didSuccessfullyTransferAmount:(double)amount fromAccount:(NSString * _Nonnull)senderAccountID toAccuntID:(NSString * _Nonnull)recipientAccountID;
		[Abstract]
		[Export ("autoFlow:didSuccessfullyTransferAmount:fromAccount:toAccuntID:")]
		void DidSuccessfullyTransferAmount (DPCAutoFlow autoFlow, double amount, string senderAccountID, string recipientAccountID);

		// @required -(void)autoFlow:(DPCAutoFlow * _Nonnull)autoFlow didFailToTransferFromAccount:(NSString * _Nonnull)senderAccountID toAccuntID:(NSString * _Nullable)recipientAccountID withError:(NSError * _Nonnull)error;
		[Abstract]
		[Export ("autoFlow:didFailToTransferFromAccount:toAccuntID:withError:")]
		void DidFailToTransferFromAccount (DPCAutoFlow autoFlow, string senderAccountID, [NullAllowed] string recipientAccountID, NSError error);
	}

	// @interface DPCAutoFlow : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DPCAutoFlow
	{
		[Wrap ("WeakConnectDelegate")]
		[NullAllowed]
		DPCConnectDelegate ConnectDelegate { get; set; }

		// @property (nonatomic, weak) id<DPCConnectDelegate> _Nullable connectDelegate;
		[NullAllowed, Export ("connectDelegate", ArgumentSemantic.Weak)]
		NSObject WeakConnectDelegate { get; set; }

		[Wrap ("WeakAutoflowDelegate")]
		[NullAllowed]
		DPCAutoFlowDelegate AutoflowDelegate { get; set; }

		// @property (nonatomic, weak) id<DPCAutoFlowDelegate> _Nullable autoflowDelegate;
		[NullAllowed, Export ("autoflowDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAutoflowDelegate { get; set; }

		// @property (nonatomic, strong) DPCConfigurations * _Nonnull configurations;
		[Export ("configurations", ArgumentSemantic.Strong)]
		DPCConfigurations Configurations { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull clientUserID;
		[Export ("clientUserID")]
		string ClientUserID { get; set; }

		// -(instancetype _Nonnull)initWithConfigurations:(DPCConfigurations * _Nonnull)configurations clientUserID:(NSString * _Nonnull)clientUserID;
		[Export ("initWithConfigurations:clientUserID:")]
		IntPtr Constructor (DPCConfigurations configurations, string clientUserID);

		// -(void)present;
		[Export ("present")]
		void Present ();

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion ([NullAllowed] Action completion);
	}

	// @protocol DPCConnectDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface DPCConnectDelegate
	{
		// @required -(void)connectDidSuccessfullyConnectToBankID:(NSString * _Nonnull)bankID userID:(NSString * _Nonnull)userID;
		[Abstract]
		[Export ("connectDidSuccessfullyConnectToBankID:userID:")]
		void ConnectDidSuccessfullyConnectToBankID (string bankID, string userID);

		// @required -(void)connectDidFailConnectingToBankID:(NSString * _Nonnull)bankID withError:(NSString * _Nonnull)error;
		[Abstract]
		[Export ("connectDidFailConnectingToBankID:withError:")]
		void ConnectDidFailConnectingToBankID (string bankID, string error);

		// @required -(void)connectBeneficiaryInfoForBankWithID:(NSString * _Nonnull)bankID beneficiaryInfo:(void (^ _Nonnull)(DPCBeneficiaryInfo * _Nullable))info;
		[Abstract]
		[Export ("connectBeneficiaryInfoForBankWithID:beneficiaryInfo:")]
		void ConnectBeneficiaryInfoForBankWithID (string bankID, Action<DPCBeneficiaryInfo> info);

		// @required -(void)connectDidProceedWithBankID:(NSString * _Nonnull)bankID userID:(NSString * _Nonnull)userID;
		[Abstract]
		[Export ("connectDidProceedWithBankID:userID:")]
		void ConnectDidProceedWithBankID (string bankID, string userID);
	}

	// @interface DPCConnect : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DPCConnect
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		DPCConnectDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<DPCConnectDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) DPCConfigurations * _Nonnull configurations;
		[Export ("configurations", ArgumentSemantic.Strong)]
		DPCConfigurations Configurations { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull clientUserID;
		[Export ("clientUserID")]
		string ClientUserID { get; set; }

		// -(instancetype _Nonnull)initWithConfigurations:(DPCConfigurations * _Nonnull)configurations clientUserID:(NSString * _Nonnull)clientUserID;
		[Export ("initWithConfigurations:clientUserID:")]
		IntPtr Constructor (DPCConfigurations configurations, string clientUserID);

		// -(void)present;
		[Export ("present")]
		void Present ();

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export ("dismissWithCompletion:")]
		void DismissWithCompletion ([NullAllowed] Action completion);

		// -(NSArray<DPCConnectionDetails *> * _Nonnull)getConnections;
		[Export ("getConnections")]
		[Verify (MethodToProperty)]
		DPCConnectionDetails[] Connections { get; }
	}

	// @interface DPCNumber : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCNumber
	{
		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
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
	[BaseType (typeof(NSObject))]
	interface DPCIdentification
	{
		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull value;
		[Export ("value")]
		string Value { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}
	
	// @interface DPCIdentity : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCIdentity
	{
		// @property (copy, nonatomic) NSString * _Nonnull nationality;
		[Export ("nationality")]
		string Nationality { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull dateOfBirth;
		[Export ("dateOfBirth")]
		string DateOfBirth { get; set; }

		// @property (copy, nonatomic) NSArray<DPCNumber *> * _Nonnull numbers;
		[Export ("numbers", ArgumentSemantic.Copy)]
		DPCNumber[] Numbers { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull emailAddress;
		[Export ("emailAddress")]
		string EmailAddress { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; set; }

		// @property (nonatomic, strong) DPCAddress * _Nonnull address;
		[Export ("address", ArgumentSemantic.Strong)]
		DPCAddress Address { get; set; }

		// @property (copy, nonatomic) NSArray<DPCIdentification *> * _Nonnull identifications;
		[Export ("identifications", ArgumentSemantic.Copy)]
		DPCIdentification[] Identifications { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCAccount : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCAccount
	{
		// @property (nonatomic, strong) NSString * _Nonnull iban;
		[Export ("iban", ArgumentSemantic.Strong)]
		string Iban { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull number;
		[Export ("number", ArgumentSemantic.Strong)]
		string Number { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull currency;
		[Export ("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull type;
		[Export ("type", ArgumentSemantic.Strong)]
		string Type { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull accountID;
		[Export ("accountID", ArgumentSemantic.Strong)]
		string AccountID { get; set; }

		// @property (assign, nonatomic) BOOL isFavourite;
		[Export ("isFavourite")]
		bool IsFavourite { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCPair : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCPair
	{
		// @property (nonatomic, strong) NSString * _Nonnull code;
		[Export ("code", ArgumentSemantic.Strong)]
		string Code { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCBalance : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCBalance
	{
		// @property (nonatomic, strong) NSNumber * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; set; }

		// @property (nonatomic, strong) DPCPair * _Nonnull currency;
		[Export ("currency", ArgumentSemantic.Strong)]
		DPCPair Currency { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull accountNumber;
		[Export ("accountNumber", ArgumentSemantic.Strong)]
		string AccountNumber { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCTransaction : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCTransaction
	{
		// @property (nonatomic, strong) NSNumber * _Nonnull beforeAmount;
		[Export ("beforeAmount", ArgumentSemantic.Strong)]
		NSNumber BeforeAmount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull afterAmount;
		[Export ("afterAmount", ArgumentSemantic.Strong)]
		NSNumber AfterAmount { get; set; }

		// @property (nonatomic, strong) NSNumber * _Nonnull amount;
		[Export ("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; set; }

		// @property (nonatomic, strong) DPCPair * _Nonnull currency;
		[Export ("currency", ArgumentSemantic.Strong)]
		DPCPair Currency { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull date;
		[Export ("date", ArgumentSemantic.Strong)]
		NSDate Date { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull transactionDescription;
		[Export ("transactionDescription")]
		string TransactionDescription { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable details;
		[NullAllowed, Export ("details")]
		string Details { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull type;
		[Export ("type")]
		string Type { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCResult : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCResult
	{
		// @property (copy, nonatomic) NSString * _Nonnull jobID;
		[Export ("jobID")]
		string JobID { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull status;
		[Export ("status")]
		string Status { get; set; }

		// @property (assign, nonatomic) BOOL success;
		[Export ("success")]
		bool Success { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull message;
		[Export ("message")]
		string Message { get; set; }

		// -(instancetype _Nonnull)initWithDictionary:(NSDictionary<NSString *,id> * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary<NSString, NSObject> dictionary);
	}

	// @interface DPCAPI : NSObject
	[BaseType (typeof(NSObject))]
	interface DPCAPI
	{
	}

	// @interface DPCPayment : DPCAPI
	[BaseType (typeof(DPCAPI))]
	[DisableDefaultCtor]
	interface DPCPayment
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
		string UserID { get; }

		// -(instancetype _Nullable)initWithUserID:(NSString * _Nonnull)userID clientUserID:(NSString * _Nonnull)clientUserID configurations:(DPCConfigurations * _Nonnull)configurations;
		[Export ("initWithUserID:clientUserID:configurations:")]
		IntPtr Constructor (string userID, string clientUserID, DPCConfigurations configurations);

		// -(void)getBeneficiaries:(void (^ _Nullable)(NSArray<DPCBeneficiary *> * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("getBeneficiaries:")]
		void GetBeneficiaries ([NullAllowed] Action<NSArray<DPCBeneficiary>, NSError, NSString> completion);

		// -(void)createBeneficiaryWithInfo:(DPCBeneficiaryInfo * _Nonnull)info completion:(void (^ _Nullable)(DPCResult * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("createBeneficiaryWithInfo:completion:")]
		void CreateBeneficiaryWithInfo (DPCBeneficiaryInfo info, [NullAllowed] Action<DPCResult, NSError, NSString> completion);

		// -(void)createTransferWithSenderID:(NSString * _Nonnull)senderID amount:(NSNumber * _Nonnull)amount toReceiverID:(NSString * _Nonnull)receiverID completion:(void (^ _Nullable)(DPCResult * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("createTransferWithSenderID:amount:toReceiverID:completion:")]
		void CreateTransferWithSenderID (string senderID, NSNumber amount, string receiverID, [NullAllowed] Action<DPCResult, NSError, NSString> completion);

		// -(void)createTransferWithSenderID:(NSString * _Nonnull)senderID amount:(NSNumber * _Nonnull)amount iban:(NSString * _Nonnull)iban name:(NSString * _Nonnull)name completion:(void (^ _Nullable)(DPCResult * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("createTransferWithSenderID:amount:iban:name:completion:")]
		void CreateTransferWithSenderID (string senderID, NSNumber amount, string iban, string name, [NullAllowed] Action<DPCResult, NSError, NSString> completion);
	}

		// @interface DPCAuth : DPCAPI
	[BaseType (typeof(DPCAPI))]
	[DisableDefaultCtor]
	interface DPCAuth
	{
		// -(instancetype _Nullable)initWithUserID:(NSString * _Nonnull)userID clientUserID:(NSString * _Nonnull)clientUserID configurations:(DPCConfigurations * _Nonnull)configurations;
		[Export ("initWithUserID:clientUserID:configurations:")]
		IntPtr Constructor (string userID, string clientUserID, DPCConfigurations configurations);

		// -(void)delinkUser:(void (^ _Nullable)(DPCResult * _Nullable, NSError * _Nullable))completion;
		[Export ("delinkUser:")]
		void DelinkUser ([NullAllowed] Action<DPCResult, NSError> completion);
	}

	// @interface DPCData : DPCAPI
	[BaseType (typeof(DPCAPI))]
	[DisableDefaultCtor]
	interface DPCData
	{
		// -(instancetype _Nullable)initWithUserID:(NSString * _Nonnull)userID clientUserID:(NSString * _Nonnull)clientUserID configurations:(DPCConfigurations * _Nonnull)configurations;
		[Export ("initWithUserID:clientUserID:configurations:")]
		IntPtr Constructor (string userID, string clientUserID, DPCConfigurations configurations);

		// -(void)getIdentity:(void (^ _Nullable)(DPCIdentity * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("getIdentity:")]
		void GetIdentity ([NullAllowed] Action<DPCIdentity, NSError, NSString> completion);

		// -(void)getAccounts:(void (^ _Nullable)(NSArray<DPCAccount *> * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("getAccounts:")]
		void GetAccounts ([NullAllowed] Action<NSArray<DPCAccount>, NSError, NSString> completion);

		// -(void)getBalanceForAccountID:(NSString * _Nonnull)accountID completion:(void (^ _Nullable)(DPCBalance * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("getBalanceForAccountID:completion:")]
		void GetBalanceForAccountID (string accountID, [NullAllowed] Action<DPCBalance, NSError, NSString> completion);

		// -(void)getTransactionsForAccountID:(NSString * _Nonnull)accountID fromDate:(NSDate * _Nonnull)fromDate toDate:(NSDate * _Nonnull)toDate completion:(void (^ _Nullable)(NSArray<DPCTransaction *> * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("getTransactionsForAccountID:fromDate:toDate:completion:")]
		void GetTransactionsForAccountID (string accountID, NSDate fromDate, NSDate toDate, [NullAllowed] Action<NSArray<DPCTransaction>, NSError, NSString> completion);
	}

	// @interface DPCMetadata : DPCAPI
	[BaseType (typeof(DPCAPI))]
	[DisableDefaultCtor]
	interface DPCMetadata
	{
		// -(instancetype _Nullable)initWithUserID:(NSString * _Nonnull)userID clientUserID:(NSString * _Nonnull)clientUserID configurations:(DPCConfigurations * _Nonnull)configurations;
		[Export ("initWithUserID:clientUserID:configurations:")]
		IntPtr Constructor (string userID, string clientUserID, DPCConfigurations configurations);

		// -(void)getAccountMetadata:(void (^ _Nullable)(DPCBankMetadata * _Nullable, NSError * _Nullable, NSString * _Nullable))completion;
		[Export ("getAccountMetadata:")]
		void GetAccountMetadata ([NullAllowed] Action<DPCBankMetadata, NSError, NSString> completion);
	}

		// @interface DPCClient : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface DPCClient
	{
		// @property (readonly, nonatomic, strong, class) DPCClient * _Nonnull instance;
		[Static]
		[Export ("instance", ArgumentSemantic.Strong)]
		DPCClient Instance { get; }

		// @property (readonly, copy, nonatomic, class) NSArray<DPCClient *> * _Nonnull instances;
		[Static]
		[Export ("instances", ArgumentSemantic.Copy)]
		DPCClient[] Instances { get; }

		// @property (nonatomic, strong) DPCConfigurations * _Nonnull configurations;
		[Export ("configurations", ArgumentSemantic.Strong)]
		DPCConfigurations Configurations { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull userID;
		[Export ("userID")]
		string UserID { get; set; }

		// -(instancetype _Nonnull)initWithConfigurations:(DPCConfigurations * _Nonnull)configurations;
		[Export ("initWithConfigurations:")]
		IntPtr Constructor (DPCConfigurations configurations);

		// @property (readonly, nonatomic, strong) DPCConnect * _Nonnull connect;
		[Export ("connect", ArgumentSemantic.Strong)]
		DPCConnect Connect { get; }

		// @property (readonly, nonatomic, strong) DPCAutoFlow * _Nonnull autoFlow;
		[Export ("autoFlow", ArgumentSemantic.Strong)]
		DPCAutoFlow AutoFlow { get; }

		// @property (readonly, nonatomic, strong) DPCAuth * _Nonnull auth;
		[Export ("auth", ArgumentSemantic.Strong)]
		DPCAuth Auth { get; }

		// @property (readonly, nonatomic, strong) DPCData * _Nonnull data;
		[Export ("data", ArgumentSemantic.Strong)]
		DPCData Data { get; }

		// @property (readonly, nonatomic, strong) DPCMetadata * _Nonnull metadata;
		[Export ("metadata", ArgumentSemantic.Strong)]
		DPCMetadata Metadata { get; }

		// @property (readonly, nonatomic, strong) DPCPayment * _Nonnull payment;
		[Export ("payment", ArgumentSemantic.Strong)]
		DPCPayment Payment { get; }
	}

}

