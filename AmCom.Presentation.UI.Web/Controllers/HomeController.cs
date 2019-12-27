using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using AmCom.Domain.Entities;
using AmCom.Presentation.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;


namespace AmCom.Presentation.UI.Web.Controllers
{
    public class HomeController : Controller
    { 
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                IEnumerable<Aluno> aluno = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");
                    var responseTask = client.GetAsync("aluno");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Aluno>>();
                        readTask.Wait();

                        aluno = readTask.Result;
                    }
                    else
                    {
                        aluno = Enumerable.Empty<Aluno>();

                        ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o adminsitrador do sistema");
                    }
                }
                return View(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
               
        public ActionResult Edit(int id)
        {
            try
            {
                Aluno aluno = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("aluno?id=" + id.ToString());
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Aluno>>();
                        readTask.Wait();
                        aluno = readTask.Result.Where(x => x.Id == id).FirstOrDefault();
                    }
                }
                return View(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            try
            {
                var aluno = new Aluno { DataCadastro = DateTime.Now };
                return View(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult create(Aluno aluno)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/aluno");

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync("aluno", aluno);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o administrador");

                return View(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        [HttpPost]
        public ActionResult Edit(int id, [Bind]Aluno aluno)
        {
            try
            {
                if (id != aluno.Id)
                {
                    return NotFound();
                }

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/aluno");

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync("aluno", aluno);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Erro no servidor, entre em contato com o administrador");

                return View(aluno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/");

                    //HTTP DELETE
                    var deleteTask = client.DeleteAsync("aluno/" + id.ToString());
                    deleteTask.Wait();

                    var result = deleteTask.Result;
                    if (result.IsSuccessStatusCode)
                    {

                        return RedirectToAction("Index");
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
