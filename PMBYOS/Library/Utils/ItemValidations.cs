using PMBYOS.Library.Models;
using System.Windows.Forms;

namespace PMBYOS.Library.Utils
{
    class ItemValidations
    {
        public bool validTecnicos(Tecnicos tecnico){
            bool valid = true;
            if(tecnico.nome == "")
            {
                MessageBox.Show("O nome não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(tecnico.cargo == ""){
                MessageBox.Show("O cargo não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(tecnico.Contato.email == "")
            {
                MessageBox.Show("O Email não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(tecnico.Contato.celular == "(__) _____-____")
            {
                MessageBox.Show("Deve conter ao menos um celular", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(tecnico.senha == "" || tecnico.senha.Length <=5)
            {
                MessageBox.Show("Deve conter uma senha e ser maior ou igual a 5 caracteres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            return valid;

        }

        public bool validFilterTecnicos(string search)
        {
            if(search == "")
            {
                MessageBox.Show("O valor de buscar não pode estar em branco", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validLoginParams(string user, string password)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("O campo nome não pode estar vazio!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Informe sua senha para validação", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }



            return true;
        }

        public bool validBusca(string buscar)
        {
            if (buscar == "")
            {
                MessageBox.Show("O campo 'Buscar equipamento' deve ser preenchido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validFunc(Funcionarios funcionarios)
        {
            bool valid = true;
            if(funcionarios.nome == "")
            {
                MessageBox.Show("O nome deve ser preenchido!","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(funcionarios.Departamento.nomeDepartamento == "")
            {
                MessageBox.Show("O Departamento deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(funcionarios.cargo == "")
            {
                MessageBox.Show("O Cargo deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (funcionarios.Contato.email == "")
            {
                MessageBox.Show("O Email deve ser preenchido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(funcionarios.Contato.telefone == "(  )    -")
            {
                MessageBox.Show("O Telefone deve ser preenchido", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(funcionarios.encarregado == "")
            {
                MessageBox.Show("O Encarregado deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            return valid;
        }

        public bool validEquip(Equipamento equipamento)
        {
            bool valid = true;
            if(equipamento.Grupo.nome == "")
            {
                MessageBox.Show("O campo 'Grupo' deve ser preenchido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (equipamento.Grupo.nome_sub == "")
            {
                MessageBox.Show("O campo 'Sub grupo' deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (equipamento.serie == "" && equipamento.patRelacionado == "")
            {
                MessageBox.Show("O equipamento deve conter um número de série ou patrimonio relacionado!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (equipamento.Fornecedor.razao == "")
            {
                MessageBox.Show("O campo 'Fornecedor' deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (equipamento.dataAquisicao == "  /  /")
            {
                MessageBox.Show("O campo 'Data de aquisição' deve ser preenchido!","Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (equipamento.garantia == "")
            {
                MessageBox.Show("O campo 'Garantia' deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (equipamento.Departamento.nomeDepartamento == "")
            {
                MessageBox.Show("O campo 'Departamento' deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if(equipamento.Local.nome == "")
            {
                MessageBox.Show("O campo 'Local' deve ser preenchido!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            return valid;
            
        }

        public bool validForn(Fornecedor fornecedor)
        {
            bool valid = true;

            if(fornecedor.cnpj == "        /    -")
            {
                MessageBox.Show("O CNPJ deve ser preenchido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (fornecedor.incricao == "")
            {
                MessageBox.Show("O número de inscrição não pode estar vazio!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (fornecedor.Contato.email == "")
            {
                MessageBox.Show("O fornecedor deve possuir um email para contato", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (fornecedor.Contato.telefone == "(  )    -" && fornecedor.Contato.celular == "(  )     -")
            {
                MessageBox.Show("É necessário pelo menos um telefone para contato!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (fornecedor.endereco == " , nº ")
            {
                MessageBox.Show("É preciso especificar o endereço do fornecedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            if (fornecedor.razao == "")
            {
                MessageBox.Show("Informe a razão social do fornecedor", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            return valid;
        }




    }
}

