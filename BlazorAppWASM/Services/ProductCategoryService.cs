using BlazorAppWASM.Models;
using System.Net.Http.Json;

namespace BlazorAppWASM.Services
{
    /*
    This class is a service responsible for interacting with a Web API that deals with product categories. It uses HttpClient to make HTTP requests to the API endpoints defined by the apiUrl. The methods in this service correspond to common CRUD operations (Create, Read, Update, Delete) for product categories. 
     */


    public class ProductCategoryService
    {
 
        // This private field stores an HttpClient instance used for making HTTP requests.
        private readonly HttpClient _httpClient;
        

        private string apiUrl = "https://localhost:7115/ProductCategories";

        public ProductCategoryService (HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        // It uses the HttpClient to make a GET request to the `apiUrl` and expects a JSON response
        // containing an array of ProductCategory objects. The response is asynchronously converted
        // to a ProductCategory[] array and returned as a Task.
        public Task<ProductCategory[]> GetProductCategories()
        {
            return _httpClient.GetFromJsonAsync<ProductCategory[]>(apiUrl);
        }

        public Task<ProductCategory> GetProductCategory (int id)
        {
            return _httpClient.GetFromJsonAsync<ProductCategory>(apiUrl + "/" + id);
        }

        public Task <HttpResponseMessage> SaveProductCategory (ProductCategory productCategory)
        {
            return _httpClient.PostAsJsonAsync<ProductCategory>(apiUrl, productCategory);
        }

        public Task <HttpResponseMessage> UpdateProductCategory (ProductCategory productCategory)
        {
            return _httpClient.PutAsJsonAsync<ProductCategory>(apiUrl + "/" + productCategory.ProductCategoryID, productCategory);
        }

        public Task<HttpResponseMessage> DeleteProductCategory(int id)
        {
            return _httpClient.DeleteAsync(apiUrl + "/" + id);
        }
    }
}
