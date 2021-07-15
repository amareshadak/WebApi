using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Core.Domain
{
    public class MasterMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MemId { get; set; } // PK start from 1000 - admin id
        // public string Username { get; set; } // 5 to 7 charecter alpha numeric auto generated TIQ0714
        public long UserId { get; set; }
        [StringLength(50)]
        public string MemberType { get; set; } // B2B dropdown

        [StringLength(50)]
        public string BbpsId { get; set; } // textbox alpaha numeric
        [StringLength(50)]
        public string  RailId { get; set; } // textbox alpha numeric
        [StringLength(50)]
        public string RailPwd { get; set; } // textbox
        [StringLength(50)]
        public string OldMemberId { get; set; } // textbox
        public bool? ActiveMember { get; set; } // dropdown Yes / no

        public long? UnderWhiteLevel { get; set; } // pass 1001

        public long? IntroducerSuper { get; set; } // 0

        public long? IntroducerDist { get; set; } // dist id - Dropdown including company distributor

        public long? SupportMemberId { get; set; } // auto tag
        [StringLength(100)]
        public string SupportMemberName { get; set; } // auto suggetion box - admin member name concatinate with MOBILE and ID

        public long? SalesMemberId { get; set; } // Auto Tag
        [StringLength(100)]
        public string SalesMemberName { get; set; } // auto suggetion box - admin member name concatinate with MOBILE and ID

        public long? UserGroup { get; set; } // Currenty pass Gold Group ID - 1
        [StringLength(100)]
        public string MemberFirstName { get; set; } // Textbox
        [StringLength(100)]
        public string MemberLastName { get; set; } // Textbox
        [StringLength(100)]
        public string MemberFullName { get; set; } // Autotag

        public long? MemberRole { get; set; } // 1 - admin, 2- admin user, 3 - WLP, 4 - Super, 5- Dist, 6, Merchat, 7 - API User

        public int? CurrencyId { get; set; } // From currency table - Dropdown - currently pass 1 for INR

        public decimal? Balance { get; set; } = 0; // Bydefult set 0.00

        public decimal? BlockedBalance { get; set; } = 0; // Textbox decimal

        public decimal? RdsWalletBalance { get; set; } = 0; // By default set 0.00 decimal

        public decimal? RdsBlockedBalance { get; set; } = 0; // Textbox decimal

        public decimal? AepsWalletBalance { get; set; } = 0; // By default set 0.00 decimal

        public decimal? AepsBlockedBalance { get; set; } = 0; // Textbox decimal

        public decimal? AepsPayoutBalance { get; set; } = 0; // default 0.00 decimal

        public decimal? CreditLimit { get; set; } = 0; // default 0.00

        public decimal? ReservedCreditLimit { get; set; } = 0; // default 0.00

        public decimal? TempCreditLimit { get; set; } = 0; // default 0.00

        public decimal? CommissionWallet { get; set; } = 0; // // default 0.00

        [StringLength(100)]
        public string PaymentMode  { get; set; } // Dropdown , value - Direct-Indirect
        [StringLength(100)]
        public string Company { get; set; } // Textbox
        [StringLength(100)]
        public string CompanyType { get; set; } // Dropdown - 	Proprietorship - Partnership/Company - Individual
        [StringLength(500)]
        public string CompanyAddress { get; set; } // Multiline Textbox

        public int? CompanyPinNo { get; set; } // Textbox
        [StringLength(500)]
        public string ResAddress { get; set; } // Multiline Textbox

        public int? ResPinNo { get; set; } // textbox
        [StringLength(100)]
        public string City { get; set; } // Textbox
        [StringLength(100)]
        public string Pin { get; set; } // Textbox

        public int? StateId { get; set; } // Dropdown - value

        public long? CountryId  { get; set; } // Dropdown
        [StringLength(100)]
        public string EmailId { get; set; } // textbox
        [StringLength(100)]
        public string NotificationEmailId { get; set; } // textbox
        [StringLength(100)]
        public string OptionalEmailId { get; set; } // textbox
        [StringLength(100)]
        public string MemberMobileNo { get; set; } // textbox
        [StringLength(100)]
        public string NotificationMobileNo { get; set; } // textbox
        [StringLength(100)]
        public string OptionalMobileNo { get; set; } // textbox
        [StringLength(500)]
        public string MemberImage { get; set; } // Image path

        public DateTime? JoiningDate { get; set; } // Date

        public DateTime? RenewalDate { get; set; } // calculate +365 days from joining date
        [StringLength(100)]
        public string AadhaarNo { get; set; } // Textbox
        [StringLength(100)]
        public string PanNo { get; set; } // Textbox
        [StringLength(100)]
        public string AadhaarFileName { get; set; } // Image path
        [StringLength(100)]
        public string PanFileName { get; set; } // Image path

        public bool? KycVerified { get; set; } // By default false

        public long? KycVerifiedUser { get; set; } // Null

        public DateTime? KycVerificationDate  { get; set; } // Null

        public long? CreateddBy { get; set; } 
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
        public DateTime? CreatedOn { get; set; } // system datetime

        public long? DeletedBy { get; set; } // null

        public bool? GstMode { get; set; } // null

        public bool? TdsMode { get; set; } // null

        public bool? GstFlag { get; set; } // Dropdown Yes/No

        public bool? TdsFlag { get; set; } // Dropdown Yes/No
        [StringLength(100)]
        public string CompanyGstNo  { get; set; } // Text Box
        [StringLength(100)]
        public string CompanyGstMobileNo { get; set; } // Text Box
        [StringLength(100)]
        public string CompanyGstEmail { get; set; } // Text Box
        [StringLength(500)]
        public string CompanyGstAddress { get; set; } // Multiline Textbox
        [StringLength(100)]
        public string CompanyGstPin { get; set; } // Textbox
        [StringLength(100)]
        public string CompanyGstCity { get; set; } // Textbox

        public int? CompanyGstStateId { get; set; } // Dropdown

        public int? CompanyGstCountryId { get; set; } // Dropdown
        [StringLength(100)]
        public string TdsExemtionNo { get; set; } // Textbox
        [StringLength(100)]
        public string TdsExemtionLimit { get; set; } // Textbox
        [StringLength(100)]
        public string TdsExemtionRate { get; set; } // Textbox
        [StringLength(100)]
        public string ServiceTaxNo { get; set; } // Textbox
        [StringLength(500)]
        public string WhiteLabelLogo { get; set; } // Null
        [StringLength(500)]
        public string WhiteLabelLogoCss { get; set; } // Null
        [StringLength(500)]
        public string MerchantLogo { get; set; }  // Image Path
        [StringLength(500)]
        public string MerchantLogoCss { get; set; } // Default set

        public bool? IsMerchantInvoiceLogo { get; set; } // Check Box - Yes/No

        public bool? IsCorporate { get; set; } // Checkbox - Yes/No
        [StringLength(100)]
        public string SupplierPromocode { get; set; } // Textbox

        public bool? IsCharterFlight { get; set; } // Checkbox Yes

        public decimal? CorpDomesticBufferAmount { get; set; } // Textbox decimal

        public decimal? CorpIntBufferAmount { get; set; } // Textbox

        public long? SearchRatio { get; set; } // Two textbox - one for serch ratio and another for Book ratio (Side by Side)

        public long? BookRatio { get; set; }// Look SearchRatio

        [StringLength(500)]
        public string FacebookId { get; set; } // Textbox
        [StringLength(500)]
        public string WebsiteName { get; set; } // Textbox
        [StringLength(100)]
        public string RefferCode { get; set; } // Textbox
        [StringLength(100)]
        public string RegisterRefferCode { get; set; } 

        // public bool? IS_DELETED { get; set; }
        [StringLength(500)]
        public string Remarks { get; set; }// Multiline Textbox
        public byte[] RowVersion { get; set; }

        [StringLength(100)]
        public string Flag1 { get; set; } // Flag 1 to Flag 10 Null
        [StringLength(100)]
        public string Flag2 { get; set; }
        [StringLength(100)]
        public string Flag3 { get; set; }
        [StringLength(100)]
        public string Flag4 { get; set; }
        [StringLength(100)]
        public string Flag5 { get; set; }
        [StringLength(100)]
        public string Flag6 { get; set; }
        [StringLength(100)]
        public string Flag7 { get; set; }
        [StringLength(100)]
        public string Flag8 { get; set; }
        [StringLength(100)]
        public string Flag9 { get; set; }
        [StringLength(100)]
        public string Flag10 { get; set; }
    }
}
