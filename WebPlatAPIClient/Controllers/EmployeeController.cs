using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebPlatAPIClient.Models;

namespace WebPlatAPIClient.Controllers
{
    public class EmployeeController : Controller
    {

        public IActionResult Index()
        {

            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);


            client.BaseAddress = new Uri("http://localhost:5176/api/");


            string result =
            client.GetStringAsync(client.BaseAddress + "Employee").Result;

            List<EmployeeModel> employees =
                     JsonSerializer.Deserialize<List<EmployeeModel>>(result);

            return View(employees);
        }

        public IActionResult Details(int id)
        {


            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);

            client.BaseAddress = new Uri("http://localhost:5176/api/");

            string result =
            client.GetStringAsync(client.BaseAddress + $"Employee/id?id={id}").Result;

            EmployeeModel employees = JsonSerializer.Deserialize<EmployeeModel>(result);

            return View(employees);

        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel employee)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);

            client.BaseAddress = new Uri("http://localhost:5176/api/");
            string jsonEmployee = JsonSerializer.Serialize(employee);
            HttpResponseMessage response = client.PostAsync("Employee", new StringContent(jsonEmployee, System.Text.Encoding.UTF8, "application/json")).Result;




            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);

            client.BaseAddress = new Uri("http://localhost:5176/api/");

            string result =
            client.GetStringAsync(client.BaseAddress + $"Employee/id?id={id}").Result;

            EmployeeModel employees = JsonSerializer.Deserialize<EmployeeModel>(result);

            return View(employees);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeModel employee)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);

            client.BaseAddress = new Uri("http://localhost:5176/api/");
            string jsonEmployee = JsonSerializer.Serialize(employee);
            HttpResponseMessage response = client.PutAsync("Employee/id?id={id}", new StringContent(jsonEmployee, System.Text.Encoding.UTF8, "application/json")).Result;




            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);

            client.BaseAddress = new Uri("http://localhost:5176/api/");

            string result =
            client.GetStringAsync(client.BaseAddress + $"Employee/id?id={id}").Result;

            EmployeeModel employees = JsonSerializer.Deserialize<EmployeeModel>(result);

            return View(employees);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult Delete_C(EmployeeModel employee)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);

            client.BaseAddress = new Uri("http://localhost:5176/api/");
            string jsonEmployee = JsonSerializer.Serialize(employee);
        //    HttpResponseMessage response = client.DeleteAsync("Employee/id?id={id}", new StringContent(jsonEmployee, System.Text.Encoding.UTF8, "application/json")).Result;




            return RedirectToAction("Index");
        }
    }
}
