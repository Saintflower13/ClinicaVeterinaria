using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicaVeterinaria.Data
{
    class ClinicaContext : DbContext
    {
        public DbSet<AnimalEspecie> AnimaisEspecies { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<CompraPagamento> ComprasPgtos { get; set; }
        public DbSet<CompraProduto> CompraProdutos { get; set; }
        public DbSet<FormasPagamento> FormasPgto { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioFuncao> FuncionariosFuncoes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaPagamento> VendaPgto { get; set; }
        public DbSet<VendaProduto> VendasProdutos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456789;Persist Security Info=True;User ID=master;Initial Catalog=clinica_veterinaria;Data Source=MANU\\SQLEXPRESS");
        }
    }
}
