using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WEBAPI_Bravo.DinamicModel;

namespace WEBAPI_Bravo.ExternalServices
{
    public class ExternalApiService
    {
        private readonly HttpClient _httpClient;

        public ExternalApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetContactsAsync()
        {
            string url = "http://10.102.51.51:82/api/contact";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
                
            }
        }

        public async Task<string> GetContactsTopAsync(int jumlah)
        {
            string url = "http://10.102.51.51:82/api/contact?top="+ jumlah;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

              
                string responseBody = await response.Content.ReadAsStringAsync();

             
                return responseBody;
            }
            catch (HttpRequestException e)
            {
               
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {
                
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }


        public async Task<string> GetContactsbyEmail(string email)
        {
            string url = "http://10.102.51.51:82/api/contact?email=" + email;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
        public async Task<string> GetContactsbyNotelpn(string Notelpn)
        {
            string url = "http://10.102.51.51:82/api/contact?notelp=" + Notelpn;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }

        public async Task<string> GetContactsbyNotelpnAndEmail(string notelpn,string email)
        {
            string url = "http://10.102.51.51:82/api/contact?email=" + email +"&notelp=" +notelpn;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        } 
        
        
        public async Task<string> GetAccountAsync(int year)
        {
            string url = "http://10.102.51.51:82/api/accountall?year"+year;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
                
            }
        }

        public async Task<string> GetAccountTopAsync(int jumlah)
        {
            string url = "http://10.102.51.51:82/api/account?top=" + jumlah;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

              
                string responseBody = await response.Content.ReadAsStringAsync();

             
                return responseBody;
            }
            catch (HttpRequestException e)
            {
               
                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {
                
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }


        public async Task<string> GetAccountbynpwp(string npwp)
        {
            string url = "http://10.102.51.51:82/api/account?npwp=" + npwp;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
        public async Task<string> GetAccountbyName(string nama)
        {
            string url = "http://10.102.51.51:82/api/account?name=" + nama;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }

        public async Task<string> GetAccountbyNamaAndNpwp(string nama,string npwp)
        {
            string url = "http://10.102.51.51:82/api/account?npwp=" + npwp +"&nama=" +nama;

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();


                return responseBody;
            }
            catch (HttpRequestException e)
            {

                Console.WriteLine($"Request error: {e.Message}");
                throw;
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }

        public async Task<string> PostContactAsync(contact Contact)
        {

            string url = "http://10.102.51.51:82/api/contact";
            try
            {
               
                string json = System.Text.Json.JsonSerializer.Serialize(Contact);

             
                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);

          
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response received successfully:");
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    string errorBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(errorBody);
                    return errorBody;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
                return ex.Message;
            }
        }

        public async Task<string> PostAccountAsync(account Data)
        {

            string url = "http://10.102.51.51:82/api/account";
            try
            {

                string json = System.Text.Json.JsonSerializer.Serialize(Data);


                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await _httpClient.PostAsync(url, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response received successfully:");
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    string errorBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(errorBody);
                    return errorBody;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
                return ex.Message;
            }
        }

        public async Task<string> PostCaseAsync(caseData Data)
        {

            string url = "http://10.102.51.51:82/api/case";
            try
            {

                string json = System.Text.Json.JsonSerializer.Serialize(Data);


                HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");


                HttpResponseMessage response = await _httpClient.PostAsync(url, content);


                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response received successfully:");
                    Console.WriteLine(responseBody);
                    return responseBody;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                    string errorBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(errorBody);
                    return errorBody;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred: {ex.Message}");
                return ex.Message;
            }
        }
    }
   


}
