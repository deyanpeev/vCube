﻿namespace vCube.Models.VirtualMachines
{
    using System.ComponentModel.DataAnnotations;
    using vCube.Common.Constants;

    public class VirtualMachineRequestCreateModel
    {
        [Required]
        [StringLength(ValidationConstants.MaxVmNameSize, MinimumLength=ValidationConstants.MinVmNameSize)]
        public string Name { get; set; }

        [Range(ValidationConstants.MinVmCores, ValidationConstants.MaxVmCores)]
        public int CpuCores { get; set; }

        [Range(ValidationConstants.MinVmMemory, ValidationConstants.MaxVmMemory)]
        public double Memory { get; set; }

        [Range(ValidationConstants.MinVmStorage, ValidationConstants.MaxVmStorage)]
        public double Storage { get; set; }
    }
}
