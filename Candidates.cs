using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRectt
{
    public class Candidates
    {
        public string RegistrationId { get; set; }
        public int PostId { get; set; }
        public Guid guid { get; set; }
       
       
        public string FirstPreference { get; set; }
        public string SecondPreference { get; set; }   
        public string Posts { get; set; }
        public string CandidateName { get; set; }
        public DateTime Dob { get; set; }
        public string ApplicantionNo { get; set; }
        public string RollNo { get; set; }
        public string YrOfAppearanceInClat { get; set; }
        public string FathersName { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public bool IsExServiceMan { get; set; }
        public DateTime ServiceFromDate { get; set; }
        public DateTime ServiceUptoDate { get; set; }
        public DateTime DateOfDischarging { get; set; }
        public string Category { get; set; }
        public string MinorityCommunity { get; set; }
        public string DomicileState { get; set; }
        public string Nationality { get; set; }
        public bool IsRiotvictim { get; set; }
        public bool IsJKDomicileDuring {get; set;}
        public bool IsPersonWithDisability { get; set; }
        public bool IsRelativeAnEmployee { get; set; }
        public bool IsEmployeeOrDirector { get; set; }
        public bool IsRelativeADirector { get; set; }
        public string DirectorrelativeDetails { get; set; }

        public string DirectorName { get; set; }
        public string DirectorRelationship { get; set; }
        public double percentageOfDisability { get; set; }
        public string PwDCategory { get; set; }
        public string PwDSubcategory { get; set; }
        public bool IsPowerGridEmployee { get; set; }
        public bool IsEmployed { get; set; }
        public bool IsRelativeInPowergrid { get; set; }
        public string PowerGridEmpNo { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string Landmark { get; set; }
        public string NearestRailwaySt { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }   
        public string PinCode { get; set; }
        public string MobileNo { get; set; }
        public string STDCode { get; set; }
        public string LandlineNo { get; set; }
        public string EmailId { get; set; }
        public string AlternateEmailId { get; set; }
        public ExperienceDatails experienceDatails { get; set; }
        public BankDetails bankDetails { get; set; }
        public QualificationDetails qualificationDetails { get; set; }
        public List<RelativeDetails> relativeDetails { get; set; }
        public int Status { get; set; }
        public string RegisteredFrom { get; set; }
        public DateTime RegisteredOn { get; set; }


    }
}
