/* 
 * Service Invoice API (api.nfe.io)
 *
 * Seja bem-vindo a documentação do NFe.io!    Nossa API foi criada utilizando o padrão REST que possibilita a integração de seu sistema ao nosso, sendo assim você também pode extender ou   recriar as funcionalidades existentes na nossa plataforma, tudo isso consumindo a API que está documentada abaixo.    ### Como usar a documentação?  Logo a seguir você encontrará todos os recursos e metódos suportados pela API, sendo que essa página possibilita que você teste os recursos e métodos dirementamente através dela.     ### Como funciona a autenticação?  Você precisa de uma **chave de API (API Key)** para identificar a conta que está realizando solicitações para a API. Para isso você deve colocar sua chave de API no campo que se encontra topo desta página para que os métodos funcionem corretamente.  No seu código e integração temos suporte para autenticação de diversas formas sendo eles: **HTTP Header (Authorization ou X-NFEIO-APIKEY)** ou **HTTP Query String (api_key)** nos dois modos passando o valor da sua chave de api (API Key).  
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// WebhookSingleResource
    /// </summary>
    [DataContract]
    public partial class WebhookSingleResource :  IEquatable<WebhookSingleResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSingleResource" /> class.
        /// </summary>
        /// <param name="Hooks">Hooks.</param>
        public WebhookSingleResource(WebhookResource Hooks = default(WebhookResource))
        {
            this.Hooks = Hooks;
        }
        
        /// <summary>
        /// Gets or Sets Hooks
        /// </summary>
        [DataMember(Name="hooks", EmitDefaultValue=false)]
        public WebhookResource Hooks { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSingleResource {\n");
            sb.Append("  Hooks: ").Append(Hooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WebhookSingleResource);
        }

        /// <summary>
        /// Returns true if WebhookSingleResource instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookSingleResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSingleResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hooks == other.Hooks ||
                    this.Hooks != null &&
                    this.Hooks.Equals(other.Hooks)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Hooks != null)
                    hash = hash * 59 + this.Hooks.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}