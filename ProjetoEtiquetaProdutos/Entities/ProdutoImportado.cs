using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEtiquetaProdutos.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaDeImportaçao { get; set; }

        public ProdutoImportado() { }

        public ProdutoImportado(string nome, double preço, double taxaDeImportaçao): base(nome, preço)
        {
            TaxaDeImportaçao = taxaDeImportaçao;
        }

        public double PreçoTotal()
        {
            return Preço + TaxaDeImportaçao;
        }

        public override string Etiqueta()
        {
            return Nome
                + " R$ "
                + PreçoTotal().ToString("F2")
                + "( Taxa de importaçao: R$ "
                + TaxaDeImportaçao.ToString("F2")
                + " )";
        }


    }
}
