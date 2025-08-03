using Uebung1;
using Uebung1.Domain;
using Uebung1.Management;

void CreateBaseData()
{
    DomainDbContext.Autos.Add(new Auto("Audi", "rot", 100));
    DomainDbContext.Autos.Add(new Auto("Audi1", "rot", 100));
    DomainDbContext.Autos.Add(new Auto("Audi2", "rot", 100));
    DomainDbContext.Autos.Add(new Auto("Audi3", "rot", 100));
    DomainDbContext.Autos.Add(new Auto("Audi4", "rot", 100));
  
}

CreateBaseData();

new MainManagement();