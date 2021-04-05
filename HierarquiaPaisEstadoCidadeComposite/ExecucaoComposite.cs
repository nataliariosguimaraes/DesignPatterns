namespace HierarquiaPaisEstadoCidadeComposite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {

            var validacaoCadastro = new Pais("O cadastro não foi realizado!");


            var Pais = new Pais("Brasil");

            var EstadoA= new Pais("Minas Gerais");
            var EstadoB = new Pais("Rio Grande do Norte");

            var CidadeA= new Pais("Araxá");
            var CidadeB = new Pais("Ibia");
            var CidadeC = new Pais("Natal");


            EstadoA.AdicionarHierarquiaFilha(CidadeA);
            EstadoA.AdicionarHierarquiaFilha(CidadeB);
            EstadoB.AdicionarHierarquiaFilha(CidadeC);


            Pais.AdicionarHierarquiaFilha(EstadoA);
            Pais.AdicionarHierarquiaFilha(EstadoB);

       


            validacaoCadastro.AdicionarHierarquiaFilha(Pais);


            Pais.ExibirHierarquia(2);



        }
    }
}
