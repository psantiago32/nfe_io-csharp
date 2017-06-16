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
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="Country">Sigla do País (padrão ISO 3166-1 mais em http://bit.ly/1OgCkxd)  Exemplo: BRA, USD, ARG (required).</param>
        /// <param name="PostalCode">CEP (Exemplo: 99999-999).</param>
        /// <param name="Street">Logradouro (required).</param>
        /// <param name="Number">Número (Exemplo: 185 ou S/N) (required).</param>
        /// <param name="AdditionalInformation">Complemento (Exemplo: BLC A; APT 10.</param>
        /// <param name="District">Bairro.</param>
        /// <param name="City">Cidade.</param>
        /// <param name="State">Estado.</param>
        public Address(string Country = default(string), string PostalCode = default(string), string Street = default(string), string Number = default(string), string AdditionalInformation = default(string), string District = default(string), AddressCity City = default(AddressCity), string State = default(string))
        {
            // to ensure "Country" is required (not null)
            if (Country == null)
            {
                throw new InvalidDataException("Country is a required property for Address and cannot be null");
            }
            else
            {
                this.Country = Country;
            }
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for Address and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "Number" is required (not null)
            if (Number == null)
            {
                throw new InvalidDataException("Number is a required property for Address and cannot be null");
            }
            else
            {
                this.Number = Number;
            }
            this.PostalCode = PostalCode;
            this.AdditionalInformation = AdditionalInformation;
            this.District = District;
            this.City = City;
            this.State = State;
        }
        
        /// <summary>
        /// Sigla do País (padrão ISO 3166-1 mais em http://bit.ly/1OgCkxd)  Exemplo: BRA, USD, ARG
        /// </summary>
        /// <value>Sigla do País (padrão ISO 3166-1 mais em http://bit.ly/1OgCkxd)  Exemplo: BRA, USD, ARG</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// CEP (Exemplo: 99999-999)
        /// </summary>
        /// <value>CEP (Exemplo: 99999-999)</value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Logradouro
        /// </summary>
        /// <value>Logradouro</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// Número (Exemplo: 185 ou S/N)
        /// </summary>
        /// <value>Número (Exemplo: 185 ou S/N)</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }
        /// <summary>
        /// Complemento (Exemplo: BLC A; APT 10
        /// </summary>
        /// <value>Complemento (Exemplo: BLC A; APT 10</value>
        [DataMember(Name="additionalInformation", EmitDefaultValue=false)]
        public string AdditionalInformation { get; set; }
        /// <summary>
        /// Bairro
        /// </summary>
        /// <value>Bairro</value>
        [DataMember(Name="district", EmitDefaultValue=false)]
        public string District { get; set; }
        /// <summary>
        /// Cidade
        /// </summary>
        /// <value>Cidade</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public AddressCity City { get; set; }
        /// <summary>
        /// Estado
        /// </summary>
        /// <value>Estado</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.AdditionalInformation == other.AdditionalInformation ||
                    this.AdditionalInformation != null &&
                    this.AdditionalInformation.Equals(other.AdditionalInformation)
                ) && 
                (
                    this.District == other.District ||
                    this.District != null &&
                    this.District.Equals(other.District)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.AdditionalInformation != null)
                    hash = hash * 59 + this.AdditionalInformation.GetHashCode();
                if (this.District != null)
                    hash = hash * 59 + this.District.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
