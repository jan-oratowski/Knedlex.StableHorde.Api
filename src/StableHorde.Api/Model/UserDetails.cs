/*
 * AI Horde
 *
 * The API documentation for the AI Horde
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = StableHorde.Api.Client.OpenAPIDateConverter;

namespace StableHorde.Api.Model
{
    /// <summary>
    /// UserDetails
    /// </summary>
    [DataContract(Name = "UserDetails")]
    public partial class UserDetails : IEquatable<UserDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetails" /> class.
        /// </summary>
        /// <param name="username">The user&#39;s unique Username. It is a combination of their chosen alias plus their ID..</param>
        /// <param name="id">The user unique ID. It is always an integer..</param>
        /// <param name="kudos">The amount of Kudos this user has. The amount of Kudos determines the priority when requesting image generations..</param>
        /// <param name="evaluatingKudos">(Privileged) The amount of Evaluating Kudos this untrusted user has from generations and uptime. When this number reaches a prespecified threshold, they automatically become trusted..</param>
        /// <param name="concurrency">How many concurrent generations this user may request..</param>
        /// <param name="workerInvited">Whether this user has been invited to join a worker to the AI Horde and how many of them. When 0, this user cannot add (new) workers to the horde..</param>
        /// <param name="moderator">This user is a AI Horde moderator..</param>
        /// <param name="kudosDetails">kudosDetails.</param>
        /// <param name="workerCount">How many workers this user has created (active or inactive)..</param>
        /// <param name="workerIds">workerIds.</param>
        /// <param name="sharedkeyIds">sharedkeyIds.</param>
        /// <param name="monthlyKudos">monthlyKudos.</param>
        /// <param name="trusted">This user is a trusted member of the AI Horde..</param>
        /// <param name="flagged">(Privileged) This user has been flagged for suspicious activity..</param>
        /// <param name="vpn">(Privileged) This user has been given the VPN role..</param>
        /// <param name="service">This is a service account used by a horde proxy..</param>
        /// <param name="education">This is an education account used schools and universities..</param>
        /// <param name="special">(Privileged) This user has been given the Special role..</param>
        /// <param name="suspicious">(Privileged) How much suspicion this user has accumulated..</param>
        /// <param name="pseudonymous">If true, this user has not registered using an oauth service..</param>
        /// <param name="contact">(Privileged) Contact details for the horde admins to reach the user in case of emergency..</param>
        /// <param name="adminComment">(Privileged) Information about this users by the admins.</param>
        /// <param name="accountAge">How many seconds since this account was created..</param>
        /// <param name="usage">usage.</param>
        /// <param name="contributions">contributions.</param>
        /// <param name="records">records.</param>
        public UserDetails(string username = default(string), int id = default(int), decimal kudos = default(decimal), decimal evaluatingKudos = default(decimal), int concurrency = default(int), int workerInvited = default(int), bool moderator = default(bool), UserKudosDetails kudosDetails = default(UserKudosDetails), int workerCount = default(int), List<string> workerIds = default(List<string>), List<string> sharedkeyIds = default(List<string>), MonthlyKudos monthlyKudos = default(MonthlyKudos), bool trusted = default(bool), bool flagged = default(bool), bool vpn = default(bool), bool service = default(bool), bool education = default(bool), bool special = default(bool), int suspicious = default(int), bool pseudonymous = default(bool), string contact = default(string), string adminComment = default(string), int accountAge = default(int), UsageDetails usage = default(UsageDetails), ContributionsDetails contributions = default(ContributionsDetails), UserRecords records = default(UserRecords))
        {
            this.Username = username;
            this.Id = id;
            this.Kudos = kudos;
            this.EvaluatingKudos = evaluatingKudos;
            this.Concurrency = concurrency;
            this.WorkerInvited = workerInvited;
            this.Moderator = moderator;
            this.KudosDetails = kudosDetails;
            this.WorkerCount = workerCount;
            this.WorkerIds = workerIds;
            this.SharedkeyIds = sharedkeyIds;
            this.MonthlyKudos = monthlyKudos;
            this.Trusted = trusted;
            this.Flagged = flagged;
            this.Vpn = vpn;
            this.Service = service;
            this.Education = education;
            this.Special = special;
            this.Suspicious = suspicious;
            this.Pseudonymous = pseudonymous;
            this.Contact = contact;
            this.AdminComment = adminComment;
            this.AccountAge = accountAge;
            this.Usage = usage;
            this.Contributions = contributions;
            this.Records = records;
        }

        /// <summary>
        /// The user&#39;s unique Username. It is a combination of their chosen alias plus their ID.
        /// </summary>
        /// <value>The user&#39;s unique Username. It is a combination of their chosen alias plus their ID.</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// The user unique ID. It is always an integer.
        /// </summary>
        /// <value>The user unique ID. It is always an integer.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The amount of Kudos this user has. The amount of Kudos determines the priority when requesting image generations.
        /// </summary>
        /// <value>The amount of Kudos this user has. The amount of Kudos determines the priority when requesting image generations.</value>
        [DataMember(Name = "kudos", EmitDefaultValue = false)]
        public decimal Kudos { get; set; }

        /// <summary>
        /// (Privileged) The amount of Evaluating Kudos this untrusted user has from generations and uptime. When this number reaches a prespecified threshold, they automatically become trusted.
        /// </summary>
        /// <value>(Privileged) The amount of Evaluating Kudos this untrusted user has from generations and uptime. When this number reaches a prespecified threshold, they automatically become trusted.</value>
        [DataMember(Name = "evaluating_kudos", EmitDefaultValue = false)]
        public decimal EvaluatingKudos { get; set; }

        /// <summary>
        /// How many concurrent generations this user may request.
        /// </summary>
        /// <value>How many concurrent generations this user may request.</value>
        [DataMember(Name = "concurrency", EmitDefaultValue = false)]
        public int Concurrency { get; set; }

        /// <summary>
        /// Whether this user has been invited to join a worker to the AI Horde and how many of them. When 0, this user cannot add (new) workers to the horde.
        /// </summary>
        /// <value>Whether this user has been invited to join a worker to the AI Horde and how many of them. When 0, this user cannot add (new) workers to the horde.</value>
        [DataMember(Name = "worker_invited", EmitDefaultValue = false)]
        public int WorkerInvited { get; set; }

        /// <summary>
        /// This user is a AI Horde moderator.
        /// </summary>
        /// <value>This user is a AI Horde moderator.</value>
        [DataMember(Name = "moderator", EmitDefaultValue = true)]
        public bool Moderator { get; set; }

        /// <summary>
        /// Gets or Sets KudosDetails
        /// </summary>
        [DataMember(Name = "kudos_details", EmitDefaultValue = false)]
        public UserKudosDetails KudosDetails { get; set; }

        /// <summary>
        /// How many workers this user has created (active or inactive).
        /// </summary>
        /// <value>How many workers this user has created (active or inactive).</value>
        [DataMember(Name = "worker_count", EmitDefaultValue = false)]
        public int WorkerCount { get; set; }

        /// <summary>
        /// Gets or Sets WorkerIds
        /// </summary>
        [DataMember(Name = "worker_ids", EmitDefaultValue = false)]
        public List<string> WorkerIds { get; set; }

        /// <summary>
        /// Gets or Sets SharedkeyIds
        /// </summary>
        [DataMember(Name = "sharedkey_ids", EmitDefaultValue = false)]
        public List<string> SharedkeyIds { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyKudos
        /// </summary>
        [DataMember(Name = "monthly_kudos", EmitDefaultValue = false)]
        public MonthlyKudos MonthlyKudos { get; set; }

        /// <summary>
        /// This user is a trusted member of the AI Horde.
        /// </summary>
        /// <value>This user is a trusted member of the AI Horde.</value>
        [DataMember(Name = "trusted", EmitDefaultValue = true)]
        public bool Trusted { get; set; }

        /// <summary>
        /// (Privileged) This user has been flagged for suspicious activity.
        /// </summary>
        /// <value>(Privileged) This user has been flagged for suspicious activity.</value>
        [DataMember(Name = "flagged", EmitDefaultValue = true)]
        public bool Flagged { get; set; }

        /// <summary>
        /// (Privileged) This user has been given the VPN role.
        /// </summary>
        /// <value>(Privileged) This user has been given the VPN role.</value>
        [DataMember(Name = "vpn", EmitDefaultValue = true)]
        public bool Vpn { get; set; }

        /// <summary>
        /// This is a service account used by a horde proxy.
        /// </summary>
        /// <value>This is a service account used by a horde proxy.</value>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public bool Service { get; set; }

        /// <summary>
        /// This is an education account used schools and universities.
        /// </summary>
        /// <value>This is an education account used schools and universities.</value>
        [DataMember(Name = "education", EmitDefaultValue = true)]
        public bool Education { get; set; }

        /// <summary>
        /// (Privileged) This user has been given the Special role.
        /// </summary>
        /// <value>(Privileged) This user has been given the Special role.</value>
        [DataMember(Name = "special", EmitDefaultValue = true)]
        public bool Special { get; set; }

        /// <summary>
        /// (Privileged) How much suspicion this user has accumulated.
        /// </summary>
        /// <value>(Privileged) How much suspicion this user has accumulated.</value>
        [DataMember(Name = "suspicious", EmitDefaultValue = false)]
        public int Suspicious { get; set; }

        /// <summary>
        /// If true, this user has not registered using an oauth service.
        /// </summary>
        /// <value>If true, this user has not registered using an oauth service.</value>
        [DataMember(Name = "pseudonymous", EmitDefaultValue = true)]
        public bool Pseudonymous { get; set; }

        /// <summary>
        /// (Privileged) Contact details for the horde admins to reach the user in case of emergency.
        /// </summary>
        /// <value>(Privileged) Contact details for the horde admins to reach the user in case of emergency.</value>
        [DataMember(Name = "contact", EmitDefaultValue = false)]
        public string Contact { get; set; }

        /// <summary>
        /// (Privileged) Information about this users by the admins
        /// </summary>
        /// <value>(Privileged) Information about this users by the admins</value>
        [DataMember(Name = "admin_comment", EmitDefaultValue = false)]
        public string AdminComment { get; set; }

        /// <summary>
        /// How many seconds since this account was created.
        /// </summary>
        /// <value>How many seconds since this account was created.</value>
        [DataMember(Name = "account_age", EmitDefaultValue = false)]
        public int AccountAge { get; set; }

        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        public UsageDetails Usage { get; set; }

        /// <summary>
        /// Gets or Sets Contributions
        /// </summary>
        [DataMember(Name = "contributions", EmitDefaultValue = false)]
        public ContributionsDetails Contributions { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public UserRecords Records { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserDetails {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Kudos: ").Append(Kudos).Append("\n");
            sb.Append("  EvaluatingKudos: ").Append(EvaluatingKudos).Append("\n");
            sb.Append("  Concurrency: ").Append(Concurrency).Append("\n");
            sb.Append("  WorkerInvited: ").Append(WorkerInvited).Append("\n");
            sb.Append("  Moderator: ").Append(Moderator).Append("\n");
            sb.Append("  KudosDetails: ").Append(KudosDetails).Append("\n");
            sb.Append("  WorkerCount: ").Append(WorkerCount).Append("\n");
            sb.Append("  WorkerIds: ").Append(WorkerIds).Append("\n");
            sb.Append("  SharedkeyIds: ").Append(SharedkeyIds).Append("\n");
            sb.Append("  MonthlyKudos: ").Append(MonthlyKudos).Append("\n");
            sb.Append("  Trusted: ").Append(Trusted).Append("\n");
            sb.Append("  Flagged: ").Append(Flagged).Append("\n");
            sb.Append("  Vpn: ").Append(Vpn).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  Special: ").Append(Special).Append("\n");
            sb.Append("  Suspicious: ").Append(Suspicious).Append("\n");
            sb.Append("  Pseudonymous: ").Append(Pseudonymous).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  AdminComment: ").Append(AdminComment).Append("\n");
            sb.Append("  AccountAge: ").Append(AccountAge).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
            sb.Append("  Contributions: ").Append(Contributions).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserDetails);
        }

        /// <summary>
        /// Returns true if UserDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Kudos == input.Kudos ||
                    this.Kudos.Equals(input.Kudos)
                ) && 
                (
                    this.EvaluatingKudos == input.EvaluatingKudos ||
                    this.EvaluatingKudos.Equals(input.EvaluatingKudos)
                ) && 
                (
                    this.Concurrency == input.Concurrency ||
                    this.Concurrency.Equals(input.Concurrency)
                ) && 
                (
                    this.WorkerInvited == input.WorkerInvited ||
                    this.WorkerInvited.Equals(input.WorkerInvited)
                ) && 
                (
                    this.Moderator == input.Moderator ||
                    this.Moderator.Equals(input.Moderator)
                ) && 
                (
                    this.KudosDetails == input.KudosDetails ||
                    (this.KudosDetails != null &&
                    this.KudosDetails.Equals(input.KudosDetails))
                ) && 
                (
                    this.WorkerCount == input.WorkerCount ||
                    this.WorkerCount.Equals(input.WorkerCount)
                ) && 
                (
                    this.WorkerIds == input.WorkerIds ||
                    this.WorkerIds != null &&
                    input.WorkerIds != null &&
                    this.WorkerIds.SequenceEqual(input.WorkerIds)
                ) && 
                (
                    this.SharedkeyIds == input.SharedkeyIds ||
                    this.SharedkeyIds != null &&
                    input.SharedkeyIds != null &&
                    this.SharedkeyIds.SequenceEqual(input.SharedkeyIds)
                ) && 
                (
                    this.MonthlyKudos == input.MonthlyKudos ||
                    (this.MonthlyKudos != null &&
                    this.MonthlyKudos.Equals(input.MonthlyKudos))
                ) && 
                (
                    this.Trusted == input.Trusted ||
                    this.Trusted.Equals(input.Trusted)
                ) && 
                (
                    this.Flagged == input.Flagged ||
                    this.Flagged.Equals(input.Flagged)
                ) && 
                (
                    this.Vpn == input.Vpn ||
                    this.Vpn.Equals(input.Vpn)
                ) && 
                (
                    this.Service == input.Service ||
                    this.Service.Equals(input.Service)
                ) && 
                (
                    this.Education == input.Education ||
                    this.Education.Equals(input.Education)
                ) && 
                (
                    this.Special == input.Special ||
                    this.Special.Equals(input.Special)
                ) && 
                (
                    this.Suspicious == input.Suspicious ||
                    this.Suspicious.Equals(input.Suspicious)
                ) && 
                (
                    this.Pseudonymous == input.Pseudonymous ||
                    this.Pseudonymous.Equals(input.Pseudonymous)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.AdminComment == input.AdminComment ||
                    (this.AdminComment != null &&
                    this.AdminComment.Equals(input.AdminComment))
                ) && 
                (
                    this.AccountAge == input.AccountAge ||
                    this.AccountAge.Equals(input.AccountAge)
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
                ) && 
                (
                    this.Contributions == input.Contributions ||
                    (this.Contributions != null &&
                    this.Contributions.Equals(input.Contributions))
                ) && 
                (
                    this.Records == input.Records ||
                    (this.Records != null &&
                    this.Records.Equals(input.Records))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.Kudos.GetHashCode();
                hashCode = (hashCode * 59) + this.EvaluatingKudos.GetHashCode();
                hashCode = (hashCode * 59) + this.Concurrency.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkerInvited.GetHashCode();
                hashCode = (hashCode * 59) + this.Moderator.GetHashCode();
                if (this.KudosDetails != null)
                {
                    hashCode = (hashCode * 59) + this.KudosDetails.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WorkerCount.GetHashCode();
                if (this.WorkerIds != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerIds.GetHashCode();
                }
                if (this.SharedkeyIds != null)
                {
                    hashCode = (hashCode * 59) + this.SharedkeyIds.GetHashCode();
                }
                if (this.MonthlyKudos != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyKudos.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Trusted.GetHashCode();
                hashCode = (hashCode * 59) + this.Flagged.GetHashCode();
                hashCode = (hashCode * 59) + this.Vpn.GetHashCode();
                hashCode = (hashCode * 59) + this.Service.GetHashCode();
                hashCode = (hashCode * 59) + this.Education.GetHashCode();
                hashCode = (hashCode * 59) + this.Special.GetHashCode();
                hashCode = (hashCode * 59) + this.Suspicious.GetHashCode();
                hashCode = (hashCode * 59) + this.Pseudonymous.GetHashCode();
                if (this.Contact != null)
                {
                    hashCode = (hashCode * 59) + this.Contact.GetHashCode();
                }
                if (this.AdminComment != null)
                {
                    hashCode = (hashCode * 59) + this.AdminComment.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountAge.GetHashCode();
                if (this.Usage != null)
                {
                    hashCode = (hashCode * 59) + this.Usage.GetHashCode();
                }
                if (this.Contributions != null)
                {
                    hashCode = (hashCode * 59) + this.Contributions.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}