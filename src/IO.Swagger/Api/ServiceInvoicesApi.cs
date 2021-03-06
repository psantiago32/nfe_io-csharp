using IO.Swagger.Client;
using IO.Swagger.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceInvoicesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        string ServiceInvoicesDelete (string companyId, string id);

        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ServiceInvoicesDeleteWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>ServiceInvoiceCollectionResource</returns>
        ServiceInvoiceCollectionResource ServiceInvoicesGet (string companyId, int? pageCount = null, int? pageIndex = null);

        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>ApiResponse of ServiceInvoiceCollectionResource</returns>
        ApiResponse<ServiceInvoiceCollectionResource> ServiceInvoicesGetWithHttpInfo (string companyId, int? pageCount = null, int? pageIndex = null);
        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        string ServiceInvoicesGetDocumentPdf (string companyId, string id);

        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ServiceInvoicesGetDocumentPdfWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        string ServiceInvoicesGetDocumentXml (string companyId, string id);

        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ServiceInvoicesGetDocumentXmlWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do API Key da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ServiceInvoiceResource</returns>
        ServiceInvoiceResource ServiceInvoicesGet_0 (string companyId, string id);

        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do API Key da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of ServiceInvoiceResource</returns>
        ApiResponse<ServiceInvoiceResource> ServiceInvoicesGet_0WithHttpInfo (string companyId, string id);
        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>ServiceInvoiceResource</returns>
        ServiceInvoiceResource ServiceInvoicesPost (string companyId, ServiceInvoiceIssueMessage item);

        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>ApiResponse of ServiceInvoiceResource</returns>
        ApiResponse<ServiceInvoiceResource> ServiceInvoicesPostWithHttpInfo (string companyId, ServiceInvoiceIssueMessage item);
        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>string</returns>
        string ServiceInvoicesPullProcess (string companyId, DateRange dateRange);

        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ServiceInvoicesPullProcessWithHttpInfo (string companyId, DateRange dateRange);
        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        string ServiceInvoicesSendEmail (string companyId, string id);

        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> ServiceInvoicesSendEmailWithHttpInfo (string companyId, string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ServiceInvoicesDeleteAsync (string companyId, string id);

        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesDeleteAsyncWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>Task of ServiceInvoiceCollectionResource</returns>
        System.Threading.Tasks.Task<ServiceInvoiceCollectionResource> ServiceInvoicesGetAsync (string companyId, int? pageCount = null, int? pageIndex = null);

        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>Task of ApiResponse (ServiceInvoiceCollectionResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceInvoiceCollectionResource>> ServiceInvoicesGetAsyncWithHttpInfo (string companyId, int? pageCount = null, int? pageIndex = null);
        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ServiceInvoicesGetDocumentPdfAsync (string companyId, string id);

        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesGetDocumentPdfAsyncWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ServiceInvoicesGetDocumentXmlAsync (string companyId, string id);

        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesGetDocumentXmlAsyncWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do API Key da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ServiceInvoiceResource</returns>
        System.Threading.Tasks.Task<ServiceInvoiceResource> ServiceInvoicesGet_0Async (string companyId, string id);

        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do API Key da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (ServiceInvoiceResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceInvoiceResource>> ServiceInvoicesGet_0AsyncWithHttpInfo (string companyId, string id);
        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>Task of ServiceInvoiceResource</returns>
        System.Threading.Tasks.Task<ServiceInvoiceResource> ServiceInvoicesPostAsync (string companyId, ServiceInvoiceIssueMessage item);

        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>Task of ApiResponse (ServiceInvoiceResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServiceInvoiceResource>> ServiceInvoicesPostAsyncWithHttpInfo (string companyId, ServiceInvoiceIssueMessage item);
        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ServiceInvoicesPullProcessAsync (string companyId, DateRange dateRange);

        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesPullProcessAsyncWithHttpInfo (string companyId, DateRange dateRange);
        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> ServiceInvoicesSendEmailAsync (string companyId, string id);

        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)
        /// </summary>
        /// <remarks>
        /// Você precisará do APIKEY da Empresa
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesSendEmailAsyncWithHttpInfo (string companyId, string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ServiceInvoicesApi : IServiceInvoicesApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInvoicesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceInvoicesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceInvoicesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ServiceInvoicesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        public string ServiceInvoicesDelete (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = ServiceInvoicesDeleteWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ServiceInvoicesDeleteWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesDelete");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesDelete");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ServiceInvoicesDeleteAsync (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = await ServiceInvoicesDeleteAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cancelar uma Nota Fiscal de Serviços (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesDeleteAsyncWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesDelete");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesDelete");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesDelete", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>ServiceInvoiceCollectionResource</returns>
        public ServiceInvoiceCollectionResource ServiceInvoicesGet (string companyId, int? pageCount = null, int? pageIndex = null)
        {
             ApiResponse<ServiceInvoiceCollectionResource> localVarResponse = ServiceInvoicesGetWithHttpInfo(companyId, pageCount, pageIndex);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>ApiResponse of ServiceInvoiceCollectionResource</returns>
        public ApiResponse< ServiceInvoiceCollectionResource > ServiceInvoicesGetWithHttpInfo (string companyId, int? pageCount = null, int? pageIndex = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGet");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (pageCount != null) localVarQueryParams.Add("pageCount", Configuration.ApiClient.ParameterToString(pageCount)); // query parameter
            if (pageIndex != null) localVarQueryParams.Add("pageIndex", Configuration.ApiClient.ParameterToString(pageIndex)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInvoiceCollectionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInvoiceCollectionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInvoiceCollectionResource)));
            
        }

        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>Task of ServiceInvoiceCollectionResource</returns>
        public async System.Threading.Tasks.Task<ServiceInvoiceCollectionResource> ServiceInvoicesGetAsync (string companyId, int? pageCount = null, int? pageIndex = null)
        {
             ApiResponse<ServiceInvoiceCollectionResource> localVarResponse = await ServiceInvoicesGetAsyncWithHttpInfo(companyId, pageCount, pageIndex);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as Notas Fiscais de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="pageCount">Items por página (optional)</param>
        /// <param name="pageIndex">Número da página (optional)</param>
        /// <returns>Task of ApiResponse (ServiceInvoiceCollectionResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceInvoiceCollectionResource>> ServiceInvoicesGetAsyncWithHttpInfo (string companyId, int? pageCount = null, int? pageIndex = null)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGet");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (pageCount != null) localVarQueryParams.Add("pageCount", Configuration.ApiClient.ParameterToString(pageCount)); // query parameter
            if (pageIndex != null) localVarQueryParams.Add("pageIndex", Configuration.ApiClient.ParameterToString(pageIndex)); // query parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInvoiceCollectionResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInvoiceCollectionResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInvoiceCollectionResource)));
            
        }

        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        public string ServiceInvoicesGetDocumentPdf (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = ServiceInvoicesGetDocumentPdfWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ServiceInvoicesGetDocumentPdfWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentPdf");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentPdf");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}/pdf";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGetDocumentPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ServiceInvoicesGetDocumentPdfAsync (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = await ServiceInvoicesGetDocumentPdfAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download do PDF da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesGetDocumentPdfAsyncWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentPdf");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentPdf");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}/pdf";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGetDocumentPdf", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        public string ServiceInvoicesGetDocumentXml (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = ServiceInvoicesGetDocumentXmlWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ServiceInvoicesGetDocumentXmlWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentXml");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentXml");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}/xml";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGetDocumentXml", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ServiceInvoicesGetDocumentXmlAsync (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = await ServiceInvoicesGetDocumentXmlAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download do XML da Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesGetDocumentXmlAsyncWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentXml");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesGetDocumentXml");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}/xml";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGetDocumentXml", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE) Você precisará do API Key da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ServiceInvoiceResource</returns>
        public ServiceInvoiceResource ServiceInvoicesGet_0 (string companyId, string id)
        {
             ApiResponse<ServiceInvoiceResource> localVarResponse = ServiceInvoicesGet_0WithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE) Você precisará do API Key da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of ServiceInvoiceResource</returns>
        public ApiResponse< ServiceInvoiceResource > ServiceInvoicesGet_0WithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGet_0");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesGet_0");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGet_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInvoiceResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInvoiceResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInvoiceResource)));
            
        }

        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE) Você precisará do API Key da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ServiceInvoiceResource</returns>
        public async System.Threading.Tasks.Task<ServiceInvoiceResource> ServiceInvoicesGet_0Async (string companyId, string id)
        {
             ApiResponse<ServiceInvoiceResource> localVarResponse = await ServiceInvoicesGet_0AsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Obter os detalhes de uma Nota Fiscal de Serviço (NFSE) Você precisará do API Key da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (ServiceInvoiceResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceInvoiceResource>> ServiceInvoicesGet_0AsyncWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesGet_0");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesGet_0");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesGet_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInvoiceResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInvoiceResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInvoiceResource)));
            
        }

        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>ServiceInvoiceResource</returns>
        public ServiceInvoiceResource ServiceInvoicesPost (string companyId, ServiceInvoiceIssueMessage item)
        {
             ApiResponse<ServiceInvoiceResource> localVarResponse = ServiceInvoicesPostWithHttpInfo(companyId, item);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>ApiResponse of ServiceInvoiceResource</returns>
        public ApiResponse< ServiceInvoiceResource > ServiceInvoicesPostWithHttpInfo (string companyId, ServiceInvoiceIssueMessage item)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesPost");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling ServiceInvoicesApi->ServiceInvoicesPost");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (item != null && item.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(item); // http body (model) parameter
            }
            else
            {
                localVarPostBody = item; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInvoiceResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInvoiceResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInvoiceResource)));
            
        }

        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>Task of ServiceInvoiceResource</returns>
        public async System.Threading.Tasks.Task<ServiceInvoiceResource> ServiceInvoicesPostAsync (string companyId, ServiceInvoiceIssueMessage item)
        {
             ApiResponse<ServiceInvoiceResource> localVarResponse = await ServiceInvoicesPostAsyncWithHttpInfo(companyId, item);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Emitir uma Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="item">Dados da nota fiscal de serviço</param>
        /// <returns>Task of ApiResponse (ServiceInvoiceResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ServiceInvoiceResource>> ServiceInvoicesPostAsyncWithHttpInfo (string companyId, ServiceInvoiceIssueMessage item)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesPost");
            // verify the required parameter 'item' is set
            if (item == null)
                throw new ApiException(400, "Missing required parameter 'item' when calling ServiceInvoicesApi->ServiceInvoicesPost");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (item != null && item.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(item); // http body (model) parameter
            }
            else
            {
                localVarPostBody = item; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ServiceInvoiceResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInvoiceResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInvoiceResource)));
            
        }

        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>string</returns>
        public string ServiceInvoicesPullProcess (string companyId, DateRange dateRange)
        {
             ApiResponse<string> localVarResponse = ServiceInvoicesPullProcessWithHttpInfo(companyId, dateRange);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ServiceInvoicesPullProcessWithHttpInfo (string companyId, DateRange dateRange)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesPullProcess");
            // verify the required parameter 'dateRange' is set
            if (dateRange == null)
                throw new ApiException(400, "Missing required parameter 'dateRange' when calling ServiceInvoicesApi->ServiceInvoicesPullProcess");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/pull";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (dateRange != null && dateRange.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dateRange); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dateRange; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesPullProcess", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ServiceInvoicesPullProcessAsync (string companyId, DateRange dateRange)
        {
             ApiResponse<string> localVarResponse = await ServiceInvoicesPullProcessAsyncWithHttpInfo(companyId, dateRange);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="dateRange"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesPullProcessAsyncWithHttpInfo (string companyId, DateRange dateRange)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesPullProcess");
            // verify the required parameter 'dateRange' is set
            if (dateRange == null)
                throw new ApiException(400, "Missing required parameter 'dateRange' when calling ServiceInvoicesApi->ServiceInvoicesPullProcess");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/pull";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (dateRange != null && dateRange.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dateRange); // http body (model) parameter
            }
            else
            {
                localVarPostBody = dateRange; // byte array
            }

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesPullProcess", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>string</returns>
        public string ServiceInvoicesSendEmail (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = ServiceInvoicesSendEmailWithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > ServiceInvoicesSendEmailWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesSendEmail");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesSendEmail");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}/sendemail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesSendEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> ServiceInvoicesSendEmailAsync (string companyId, string id)
        {
             ApiResponse<string> localVarResponse = await ServiceInvoicesSendEmailAsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE) Você precisará do APIKEY da Empresa
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da Nota Fiscal de Serviço (NFSE)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> ServiceInvoicesSendEmailAsyncWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling ServiceInvoicesApi->ServiceInvoicesSendEmail");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ServiceInvoicesApi->ServiceInvoicesSendEmail");

            var localVarPath = "/v1/companies/{company_id}/serviceinvoices/{id}/sendemail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ServiceInvoicesSendEmail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

    }
}
