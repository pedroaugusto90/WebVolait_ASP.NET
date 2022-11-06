﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebVolait.ViewModels
{
    public class CadastroFuncionarioViewModel
    {
        [Display(Name = "CPF")]
        public string CPFFuncionario { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [MaxLength(100)]
        [Display(Name = "Nome", AutoGenerateFilter = false)]
        public string NomeFuncionario { get; set; }

        [Display(Name = "Nome Social")]
        [MaxLength(50)]
        public string NomeSocialFuncionario { get; set; }

        [Display(Name = "E-mail")]
        public string EmailFuncionario { get; set; }

        [Display(Name = "Número de Telefone")]
        public string TelefoneFuncionario { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [MaxLength(100)]
        public string SenhaFuncionario { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua senha")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [MaxLength(100)]
        [Compare(nameof(SenhaFuncionario), ErrorMessage = "As senhas não coincidem")]
        public string ConfirmaSenhaFuncionario { get; set; }

        [Display(Name = "Função")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        [MaxLength(100)]
        public int FuncaoFuncionario { get; set; }
    }
}