namespace  vCube.Data
{
    using vCube.Models;

    public interface IvCubeData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<VirtualMachine> VirtualMachines { get; }

        int SaveChanges();
    }
}
