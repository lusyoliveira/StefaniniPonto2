using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace StefaniniPonto2.Controllers
{
    public class FuncionarioController : Controller
    {
        //
        // GET: /Funcionario/
        public ActionResult Index()
        {
            StefaniniProntoEntities entities = new StefaniniProntoEntities();

            ViewBag.PontoList = entities.Funcionario.ToList();

            return View();
        }

        
    public ActionResult NovoFuncionario(Funcionario funcionario)
        {
        if (funcionario.Nome == null)
            {
                ViewBag.MensagemErro = "Preencha o Nome";
            }
            else if (funcionario.Salario == 0)
            { 
                ViewBag.MensagemErro = "Preencha o Email";
            }

        if (ViewBag.MensagemErro == null)
        {
            StefaniniProntoEntities entities = new StefaniniProntoEntities();

            entities.Funcionario.Add(funcionario);
            entities.SaveChanges();

            ViewData.ModelState.Clear();

            ViewBag.MensagemSucesso = "Funcionário cadastrado com sucesso!";
        }

        return View();
         
        }

    public ActionResult Editar(int Id)
    {
        StefaniniProntoEntities entities = new StefaniniProntoEntities();

        Funcionario funcionario = entities.Funcionario.Find(Id);

        return View(funcionario);

    }

    public ActionResult Gravar(Funcionario funcionario)
    {

        if (funcionario.Nome == null)
        {
            ViewBag.MensagemErro = "Preencha o Nome";
        }
        else if (funcionario.Salario == 0)
        {
            ViewBag.MensagemErro = "Preencha o salario";
        }
        
        if (ViewBag.MensagemErro == null)
        {
            StefaniniProntoEntities entities = new StefaniniProntoEntities();

            entities.Entry(funcionario).State = EntityState.Modified;
            entities.SaveChanges();
            ViewBag.MensagemSucesso = "Funcionario alterado co sucesso!";
        }


        return View("Editar");
    }
	}
}