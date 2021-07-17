using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class AddUserViewModel
    {
        [StringLength(50)]
        [Required]
        [Display(Name = "Member Type")]
        public string MemberType { get; set; }

        [StringLength(50)]
        [Display(Name = "BBPS Id")]
        public string BbpsId { get; set; }

        [StringLength(50)]
        [Display(Name = "Rail Id")]
        public string RailId { get; set; }

        [StringLength(50)]
        [Display(Name = "Rail Password")]
        public string RailPwd { get; set; }

        [StringLength(50)]
        [Display(Name = "Old Member Id")]
        public string OldMemberId { get; set; }

        [Display(Name ="Active Member")]
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
        public string PaymentMode { get; set; } // Dropdown , value - Direct-Indirect
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

        public long? CountryId { get; set; } // Dropdown
        [StringLength(100)]
        public string EmailId { get; set; } // textbox

        [StringLength(100)]
        [Required(ErrorMessage = "Notification emailid required.")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Incorrect email format.")]
        public string NotificationEmailId { get; set; } // textbox
        [StringLength(100)]
        public string OptionalEmailId { get; set; } // textbox
        [StringLength(100)]
        [Required(ErrorMessage ="Mobile no. is required.")]
        [DataType(DataType.PhoneNumber,ErrorMessage ="Incorrect mobile no format.")]
        [Display(Name = "Member Mobile No")]
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

        public DateTime? KycVerificationDate { get; set; } // Null

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
        public string CompanyGstNo { get; set; } // Text Box
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
    }
}
