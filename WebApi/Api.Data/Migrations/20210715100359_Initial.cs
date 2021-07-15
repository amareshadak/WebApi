using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterMember",
                columns: table => new
                {
                    MemId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    MemberType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BbpsId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RailPwd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OldMemberId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ActiveMember = table.Column<bool>(type: "bit", nullable: true),
                    UnderWhiteLevel = table.Column<long>(type: "bigint", nullable: true),
                    IntroducerSuper = table.Column<long>(type: "bigint", nullable: true),
                    IntroducerDist = table.Column<long>(type: "bigint", nullable: true),
                    SupportMemberId = table.Column<long>(type: "bigint", nullable: true),
                    SupportMemberName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SalesMemberId = table.Column<long>(type: "bigint", nullable: true),
                    SalesMemberName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserGroup = table.Column<long>(type: "bigint", nullable: true),
                    MemberFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MemberLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MemberFullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MemberRole = table.Column<long>(type: "bigint", nullable: true),
                    CurrencyId = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BlockedBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RdsWalletBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RdsBlockedBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AepsWalletBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AepsBlockedBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AepsPayoutBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ReservedCreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TempCreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CommissionWallet = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Company = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CompanyPinNo = table.Column<int>(type: "int", nullable: true),
                    ResAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ResPinNo = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Pin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NotificationEmailId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OptionalEmailId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MemberMobileNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NotificationMobileNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OptionalMobileNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MemberImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RenewalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AadhaarNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PanNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AadhaarFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PanFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    KycVerified = table.Column<bool>(type: "bit", nullable: true),
                    KycVerifiedUser = table.Column<long>(type: "bigint", nullable: true),
                    KycVerificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateddBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    GstMode = table.Column<bool>(type: "bit", nullable: true),
                    TdsMode = table.Column<bool>(type: "bit", nullable: true),
                    GstFlag = table.Column<bool>(type: "bit", nullable: true),
                    TdsFlag = table.Column<bool>(type: "bit", nullable: true),
                    CompanyGstNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyGstMobileNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyGstEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyGstAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CompanyGstPin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyGstCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CompanyGstStateId = table.Column<int>(type: "int", nullable: true),
                    CompanyGstCountryId = table.Column<int>(type: "int", nullable: true),
                    TdsExemtionNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TdsExemtionLimit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TdsExemtionRate = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServiceTaxNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WhiteLabelLogo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WhiteLabelLogoCss = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MerchantLogo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MerchantLogoCss = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsMerchantInvoiceLogo = table.Column<bool>(type: "bit", nullable: true),
                    IsCorporate = table.Column<bool>(type: "bit", nullable: true),
                    SupplierPromocode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsCharterFlight = table.Column<bool>(type: "bit", nullable: true),
                    CorpDomesticBufferAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CorpIntBufferAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SearchRatio = table.Column<long>(type: "bigint", nullable: true),
                    BookRatio = table.Column<long>(type: "bigint", nullable: true),
                    FacebookId = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    WebsiteName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RefferCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    RegisterRefferCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Flag1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag5 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag6 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag7 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag8 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag9 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flag10 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterMember", x => x.MemId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "MasterMember");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
