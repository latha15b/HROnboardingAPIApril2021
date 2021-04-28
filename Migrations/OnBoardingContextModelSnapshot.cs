﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnBoardingAPI.Data;

namespace OnBoardingAPI.Migrations
{
    [DbContext(typeof(OnBoardingContext))]
    partial class OnBoardingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnBoardingAPI.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.DocumentType", b =>
                {
                    b.Property<int>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocumentTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMandatory")
                        .HasColumnType("bit");

                    b.HasKey("DocumentTypeId");

                    b.ToTable("DocumentType");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.EducationCertification", b =>
                {
                    b.Property<int>("EducationCertificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertificateNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("ExpiryDateOfCertificate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOfCertifcation")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("PersonalDetailEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("EducationCertificationId");

                    b.HasIndex("PersonalDetailEmployeeId");

                    b.ToTable("EducationCertifications");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.EducationQualification", b =>
                {
                    b.Property<int>("EducationQualificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsHighestQualification")
                        .HasColumnType("bit");

                    b.Property<string>("NameOfUniversity")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("PersonalDetailEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("YearOfPassing")
                        .HasColumnType("int");

                    b.HasKey("EducationQualificationId");

                    b.HasIndex("PersonalDetailEmployeeId");

                    b.ToTable("EducationQualifications");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.GroupMedicalCover", b =>
                {
                    b.Property<int>("GroupMedicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfMarriage")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DoYouHaveKids")
                        .HasColumnType("bit");

                    b.Property<bool>("Married")
                        .HasColumnType("bit");

                    b.Property<string>("ParentOrInLawsName1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentOrInLawsName1Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentOrInLawsName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentOrInLawsName2Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SpouseDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpouseGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupMedicalId");

                    b.ToTable("GroupMedicalCovers");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.Kid", b =>
                {
                    b.Property<int>("KidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupMedicalCoverGroupMedicalId")
                        .HasColumnType("int");

                    b.Property<DateTime>("KidDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("KidGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KidName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("KidId");

                    b.HasIndex("GroupMedicalCoverGroupMedicalId");

                    b.ToTable("Kids");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.OtherDetails", b =>
                {
                    b.Property<int>("OtherDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AadhaarNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Branch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IFSCCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAsInBankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAsOnAadhaar")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NameAsOnPANCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAsOnPassport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PANNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("PlaceOfIssue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("OtherDetailsId");

                    b.ToTable("OtherDetails");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.OtherProfessionalDetails", b =>
                {
                    b.Property<int>("OtherProfessionalDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerInterfactingLevel")
                        .HasColumnType("int");

                    b.Property<int>("PresentationSkillsLevel")
                        .HasColumnType("int");

                    b.Property<string>("PrimarySkills")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("PrimarySkillsLevel")
                        .HasColumnType("int");

                    b.Property<int?>("SecondarySkillLevel")
                        .HasColumnType("int");

                    b.Property<string>("SecondarySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VerbalCommunicationLevel")
                        .HasColumnType("int");

                    b.Property<int>("WrittenCommunicationLevel")
                        .HasColumnType("int");

                    b.HasKey("OtherProfessionalDetailsId");

                    b.ToTable("OtherProfessionalDetails");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.OtpGenerator", b =>
                {
                    b.Property<int>("OtpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CellNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtpCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeoutTime")
                        .HasColumnType("datetime2");

                    b.HasKey("OtpId");

                    b.ToTable("OtpGenerator");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.PersonalDetails", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CellNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CurrentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmergencyContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("GroupMedicalCoverGroupMedicalId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeclarationStatus")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int?>("OtherDetailsId")
                        .HasColumnType("int");

                    b.Property<int?>("OtherProfessionalDetailsId")
                        .HasColumnType("int");

                    b.Property<int?>("OtpGeneratorOtpId")
                        .HasColumnType("int");

                    b.Property<string>("PermanentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<int>("PermanentAddressCityId")
                        .HasColumnType("int");

                    b.Property<int>("PermanentAddressPincode")
                        .HasColumnType("int");

                    b.Property<int>("PermanentAddressStateId")
                        .HasColumnType("int");

                    b.Property<string>("PersonalEmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("TotalYearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CityId");

                    b.HasIndex("GroupMedicalCoverGroupMedicalId");

                    b.HasIndex("OtherDetailsId");

                    b.HasIndex("OtherProfessionalDetailsId");

                    b.HasIndex("OtpGeneratorOtpId");

                    b.HasIndex("StateId");

                    b.ToTable("PersonalDetails");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.PreviousEmployer", b =>
                {
                    b.Property<int>("PreviousEmployerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AreTheExitFormalitiesCompleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<string>("HrContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrEmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsLatestLastEmployer")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastWorkingDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonalDetailEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PreviousEmployerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("ProvidentFundNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonForLeaving")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("TypeOfPFAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversalAccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreviousEmployerId");

                    b.HasIndex("PersonalDetailEmployeeId");

                    b.ToTable("PreviousEmployers");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.RatingLevel", b =>
                {
                    b.Property<int>("RatingLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RatingLevelDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RatingLevelId");

                    b.ToTable("RatingLevel");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("State");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.UploadDocuments", b =>
                {
                    b.Property<int>("UploadDocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<byte[]>("FileContent")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonalDetailEmployeeId")
                        .HasColumnType("int");

                    b.HasKey("UploadDocumentId");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("PersonalDetailEmployeeId")
                        .IsUnique();

                    b.ToTable("UploadDocuments");
                });

            modelBuilder.Entity("OnBoardingAPI.Models.EducationCertification", b =>
                {
                    b.HasOne("OnBoardingAPI.Models.PersonalDetails", "PersonalDetail")
                        .WithMany("EducationCertifications")
                        .HasForeignKey("PersonalDetailEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnBoardingAPI.Models.EducationQualification", b =>
                {
                    b.HasOne("OnBoardingAPI.Models.PersonalDetails", "PersonalDetail")
                        .WithMany("EducationQualifications")
                        .HasForeignKey("PersonalDetailEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnBoardingAPI.Models.Kid", b =>
                {
                    b.HasOne("OnBoardingAPI.Models.GroupMedicalCover", "GroupMedicalCover")
                        .WithMany("Kids")
                        .HasForeignKey("GroupMedicalCoverGroupMedicalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnBoardingAPI.Models.PersonalDetails", b =>
                {
                    b.HasOne("OnBoardingAPI.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnBoardingAPI.Models.GroupMedicalCover", "GroupMedicalCover")
                        .WithMany("PersonalDetails")
                        .HasForeignKey("GroupMedicalCoverGroupMedicalId");

                    b.HasOne("OnBoardingAPI.Models.OtherDetails", "OtherDetails")
                        .WithMany("PersonalDetails")
                        .HasForeignKey("OtherDetailsId");

                    b.HasOne("OnBoardingAPI.Models.OtherProfessionalDetails", "OtherProfessionalDetails")
                        .WithMany("PersonalDetails")
                        .HasForeignKey("OtherProfessionalDetailsId");

                    b.HasOne("OnBoardingAPI.Models.OtpGenerator", "OtpGenerator")
                        .WithMany()
                        .HasForeignKey("OtpGeneratorOtpId");

                    b.HasOne("OnBoardingAPI.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnBoardingAPI.Models.PreviousEmployer", b =>
                {
                    b.HasOne("OnBoardingAPI.Models.PersonalDetails", "PersonalDetail")
                        .WithMany("PreviousEmployers")
                        .HasForeignKey("PersonalDetailEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnBoardingAPI.Models.UploadDocuments", b =>
                {
                    b.HasOne("OnBoardingAPI.Models.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnBoardingAPI.Models.PersonalDetails", "PersonalDetail")
                        .WithOne("UploadDocuments")
                        .HasForeignKey("OnBoardingAPI.Models.UploadDocuments", "PersonalDetailEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
