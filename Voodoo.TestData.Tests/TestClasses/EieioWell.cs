using System;
using System.ComponentModel.DataAnnotations;

namespace Voodoo.TestData.Tests.TestClasses
{
	[MetadataType(typeof (EieioWellMetadata))]
	public class EieioWell
	{
		public virtual Guid EieioWellId { get; set; }
		public virtual Guid EieioRigId { get; set; }

		[StringLength(64)]
		public virtual string WellName { get; set; }

		[StringLength(20)]
		public virtual string WellNumber { get; set; }

		public virtual int JobNumber { get; set; }

		[StringLength(18)]
		public virtual string ApiWellNumber { get; set; }

		[StringLength(20)]
		public virtual string Lease { get; set; }

		public virtual DateTime? SpudDate { get; set; }

		[StringLength(32)]
		public virtual string Contractor { get; set; }

		[StringLength(64)]
		public virtual string Field { get; set; }

		[StringLength(5)]
		public virtual string BlockNumber { get; set; }

		public virtual int? WaterDepth { get; set; }

		[StringLength(20)]
		public virtual string WaterDepthUnits { get; set; }

		[StringLength(25)]
		public virtual string Parrish { get; set; }

		[StringLength(2)]
		public virtual string State { get; set; }

		[StringLength(250)]
		public virtual string Country { get; set; }

		public virtual bool IsDeleted { get; set; }
		public virtual short WellStatus { get; set; }
		public virtual bool? TightHole { get; set; }
		public virtual DateTime? FirstReportDate { get; set; }
		public virtual bool? IsTwoTour { get; set; }
		public virtual bool? RoundTimeLogHours { get; set; }
		public virtual Guid? EieioOperatorId { get; set; }
		public virtual DateTime? ModifiedUtc { get; set; }
	}
}