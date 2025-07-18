using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedadesAdm()
    {
        var adm = new Administrador();

        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "Adm";

        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("teste", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
    public void TestarGetSetPropriedadesVeiculos()
    {
        var veiculo = new Veiculo();

        veiculo.Id = 1;
        veiculo.Nome = "Onix";
        veiculo.Marca = "Chevrolet";
        veiculo.Ano = 2025;

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("Onix", veiculo.Nome);
        Assert.AreEqual("Chevrolet", veiculo.Marca);
        Assert.AreEqual(2025, veiculo.Ano);
    }
}
