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
    /// RequestValidationError
    /// </summary>
    [DataContract(Name = "RequestValidationError")]
    public partial class RequestValidationError : IEquatable<RequestValidationError>, IValidatableObject
    {
        /// <summary>
        /// The return code for this error. See: https://github.com/Haidra-Org/AI-Horde/blob/main/README_return_codes.md
        /// </summary>
        /// <value>The return code for this error. See: https://github.com/Haidra-Org/AI-Horde/blob/main/README_return_codes.md</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RcEnum
        {
            /// <summary>
            /// Enum MissingPrompt for value: MissingPrompt
            /// </summary>
            [EnumMember(Value = "MissingPrompt")]
            MissingPrompt = 1,

            /// <summary>
            /// Enum CorruptPrompt for value: CorruptPrompt
            /// </summary>
            [EnumMember(Value = "CorruptPrompt")]
            CorruptPrompt = 2,

            /// <summary>
            /// Enum KudosValidationError for value: KudosValidationError
            /// </summary>
            [EnumMember(Value = "KudosValidationError")]
            KudosValidationError = 3,

            /// <summary>
            /// Enum NoValidActions for value: NoValidActions
            /// </summary>
            [EnumMember(Value = "NoValidActions")]
            NoValidActions = 4,

            /// <summary>
            /// Enum InvalidSize for value: InvalidSize
            /// </summary>
            [EnumMember(Value = "InvalidSize")]
            InvalidSize = 5,

            /// <summary>
            /// Enum InvalidPromptSize for value: InvalidPromptSize
            /// </summary>
            [EnumMember(Value = "InvalidPromptSize")]
            InvalidPromptSize = 6,

            /// <summary>
            /// Enum TooManySteps for value: TooManySteps
            /// </summary>
            [EnumMember(Value = "TooManySteps")]
            TooManySteps = 7,

            /// <summary>
            /// Enum Profanity for value: Profanity
            /// </summary>
            [EnumMember(Value = "Profanity")]
            Profanity = 8,

            /// <summary>
            /// Enum ProfaneWorkerName for value: ProfaneWorkerName
            /// </summary>
            [EnumMember(Value = "ProfaneWorkerName")]
            ProfaneWorkerName = 9,

            /// <summary>
            /// Enum ProfaneBridgeAgent for value: ProfaneBridgeAgent
            /// </summary>
            [EnumMember(Value = "ProfaneBridgeAgent")]
            ProfaneBridgeAgent = 10,

            /// <summary>
            /// Enum ProfaneWorkerInfo for value: ProfaneWorkerInfo
            /// </summary>
            [EnumMember(Value = "ProfaneWorkerInfo")]
            ProfaneWorkerInfo = 11,

            /// <summary>
            /// Enum ProfaneUserName for value: ProfaneUserName
            /// </summary>
            [EnumMember(Value = "ProfaneUserName")]
            ProfaneUserName = 12,

            /// <summary>
            /// Enum ProfaneUserContact for value: ProfaneUserContact
            /// </summary>
            [EnumMember(Value = "ProfaneUserContact")]
            ProfaneUserContact = 13,

            /// <summary>
            /// Enum ProfaneAdminComment for value: ProfaneAdminComment
            /// </summary>
            [EnumMember(Value = "ProfaneAdminComment")]
            ProfaneAdminComment = 14,

            /// <summary>
            /// Enum ProfaneTeamName for value: ProfaneTeamName
            /// </summary>
            [EnumMember(Value = "ProfaneTeamName")]
            ProfaneTeamName = 15,

            /// <summary>
            /// Enum ProfaneTeamInfo for value: ProfaneTeamInfo
            /// </summary>
            [EnumMember(Value = "ProfaneTeamInfo")]
            ProfaneTeamInfo = 16,

            /// <summary>
            /// Enum TooLong for value: TooLong
            /// </summary>
            [EnumMember(Value = "TooLong")]
            TooLong = 17,

            /// <summary>
            /// Enum TooLongWorkerName for value: TooLongWorkerName
            /// </summary>
            [EnumMember(Value = "TooLongWorkerName")]
            TooLongWorkerName = 18,

            /// <summary>
            /// Enum TooLongUserName for value: TooLongUserName
            /// </summary>
            [EnumMember(Value = "TooLongUserName")]
            TooLongUserName = 19,

            /// <summary>
            /// Enum NameAlreadyExists for value: NameAlreadyExists
            /// </summary>
            [EnumMember(Value = "NameAlreadyExists")]
            NameAlreadyExists = 20,

            /// <summary>
            /// Enum WorkerNameAlreadyExists for value: WorkerNameAlreadyExists
            /// </summary>
            [EnumMember(Value = "WorkerNameAlreadyExists")]
            WorkerNameAlreadyExists = 21,

            /// <summary>
            /// Enum TeamNameAlreadyExists for value: TeamNameAlreadyExists
            /// </summary>
            [EnumMember(Value = "TeamNameAlreadyExists")]
            TeamNameAlreadyExists = 22,

            /// <summary>
            /// Enum PolymorphicNameConflict for value: PolymorphicNameConflict
            /// </summary>
            [EnumMember(Value = "PolymorphicNameConflict")]
            PolymorphicNameConflict = 23,

            /// <summary>
            /// Enum ImageValidationFailed for value: ImageValidationFailed
            /// </summary>
            [EnumMember(Value = "ImageValidationFailed")]
            ImageValidationFailed = 24,

            /// <summary>
            /// Enum SourceImageResolutionExceeded for value: SourceImageResolutionExceeded
            /// </summary>
            [EnumMember(Value = "SourceImageResolutionExceeded")]
            SourceImageResolutionExceeded = 25,

            /// <summary>
            /// Enum SourceImageSizeExceeded for value: SourceImageSizeExceeded
            /// </summary>
            [EnumMember(Value = "SourceImageSizeExceeded")]
            SourceImageSizeExceeded = 26,

            /// <summary>
            /// Enum SourceImageUrlInvalid for value: SourceImageUrlInvalid
            /// </summary>
            [EnumMember(Value = "SourceImageUrlInvalid")]
            SourceImageUrlInvalid = 27,

            /// <summary>
            /// Enum SourceImageUnreadable for value: SourceImageUnreadable
            /// </summary>
            [EnumMember(Value = "SourceImageUnreadable")]
            SourceImageUnreadable = 28,

            /// <summary>
            /// Enum InpaintingMissingMask for value: InpaintingMissingMask
            /// </summary>
            [EnumMember(Value = "InpaintingMissingMask")]
            InpaintingMissingMask = 29,

            /// <summary>
            /// Enum SourceMaskUnnecessary for value: SourceMaskUnnecessary
            /// </summary>
            [EnumMember(Value = "SourceMaskUnnecessary")]
            SourceMaskUnnecessary = 30,

            /// <summary>
            /// Enum UnsupportedSampler for value: UnsupportedSampler
            /// </summary>
            [EnumMember(Value = "UnsupportedSampler")]
            UnsupportedSampler = 31,

            /// <summary>
            /// Enum UnsupportedModel for value: UnsupportedModel
            /// </summary>
            [EnumMember(Value = "UnsupportedModel")]
            UnsupportedModel = 32,

            /// <summary>
            /// Enum ControlNetUnsupported for value: ControlNetUnsupported
            /// </summary>
            [EnumMember(Value = "ControlNetUnsupported")]
            ControlNetUnsupported = 33,

            /// <summary>
            /// Enum ControlNetSourceMissing for value: ControlNetSourceMissing
            /// </summary>
            [EnumMember(Value = "ControlNetSourceMissing")]
            ControlNetSourceMissing = 34,

            /// <summary>
            /// Enum ControlNetInvalidPayload for value: ControlNetInvalidPayload
            /// </summary>
            [EnumMember(Value = "ControlNetInvalidPayload")]
            ControlNetInvalidPayload = 35,

            /// <summary>
            /// Enum SourceImageRequiredForModel for value: SourceImageRequiredForModel
            /// </summary>
            [EnumMember(Value = "SourceImageRequiredForModel")]
            SourceImageRequiredForModel = 36,

            /// <summary>
            /// Enum UnexpectedModelName for value: UnexpectedModelName
            /// </summary>
            [EnumMember(Value = "UnexpectedModelName")]
            UnexpectedModelName = 37,

            /// <summary>
            /// Enum TooManyUpscalers for value: TooManyUpscalers
            /// </summary>
            [EnumMember(Value = "TooManyUpscalers")]
            TooManyUpscalers = 38,

            /// <summary>
            /// Enum ProcGenNotFound for value: ProcGenNotFound
            /// </summary>
            [EnumMember(Value = "ProcGenNotFound")]
            ProcGenNotFound = 39,

            /// <summary>
            /// Enum InvalidAestheticAttempt for value: InvalidAestheticAttempt
            /// </summary>
            [EnumMember(Value = "InvalidAestheticAttempt")]
            InvalidAestheticAttempt = 40,

            /// <summary>
            /// Enum AestheticsNotCompleted for value: AestheticsNotCompleted
            /// </summary>
            [EnumMember(Value = "AestheticsNotCompleted")]
            AestheticsNotCompleted = 41,

            /// <summary>
            /// Enum AestheticsNotPublic for value: AestheticsNotPublic
            /// </summary>
            [EnumMember(Value = "AestheticsNotPublic")]
            AestheticsNotPublic = 42,

            /// <summary>
            /// Enum AestheticsDuplicate for value: AestheticsDuplicate
            /// </summary>
            [EnumMember(Value = "AestheticsDuplicate")]
            AestheticsDuplicate = 43,

            /// <summary>
            /// Enum AestheticsMissing for value: AestheticsMissing
            /// </summary>
            [EnumMember(Value = "AestheticsMissing")]
            AestheticsMissing = 44,

            /// <summary>
            /// Enum AestheticsSolo for value: AestheticsSolo
            /// </summary>
            [EnumMember(Value = "AestheticsSolo")]
            AestheticsSolo = 45,

            /// <summary>
            /// Enum AestheticsConfused for value: AestheticsConfused
            /// </summary>
            [EnumMember(Value = "AestheticsConfused")]
            AestheticsConfused = 46,

            /// <summary>
            /// Enum AestheticsAlreadyExist for value: AestheticsAlreadyExist
            /// </summary>
            [EnumMember(Value = "AestheticsAlreadyExist")]
            AestheticsAlreadyExist = 47,

            /// <summary>
            /// Enum AestheticsServerRejected for value: AestheticsServerRejected
            /// </summary>
            [EnumMember(Value = "AestheticsServerRejected")]
            AestheticsServerRejected = 48,

            /// <summary>
            /// Enum AestheticsServerError for value: AestheticsServerError
            /// </summary>
            [EnumMember(Value = "AestheticsServerError")]
            AestheticsServerError = 49,

            /// <summary>
            /// Enum AestheticsServerDown for value: AestheticsServerDown
            /// </summary>
            [EnumMember(Value = "AestheticsServerDown")]
            AestheticsServerDown = 50,

            /// <summary>
            /// Enum AestheticsServerTimeout for value: AestheticsServerTimeout
            /// </summary>
            [EnumMember(Value = "AestheticsServerTimeout")]
            AestheticsServerTimeout = 51,

            /// <summary>
            /// Enum InvalidAPIKey for value: InvalidAPIKey
            /// </summary>
            [EnumMember(Value = "InvalidAPIKey")]
            InvalidAPIKey = 52,

            /// <summary>
            /// Enum WrongCredentials for value: WrongCredentials
            /// </summary>
            [EnumMember(Value = "WrongCredentials")]
            WrongCredentials = 53,

            /// <summary>
            /// Enum NotAdmin for value: NotAdmin
            /// </summary>
            [EnumMember(Value = "NotAdmin")]
            NotAdmin = 54,

            /// <summary>
            /// Enum NotModerator for value: NotModerator
            /// </summary>
            [EnumMember(Value = "NotModerator")]
            NotModerator = 55,

            /// <summary>
            /// Enum NotOwner for value: NotOwner
            /// </summary>
            [EnumMember(Value = "NotOwner")]
            NotOwner = 56,

            /// <summary>
            /// Enum NotPrivileged for value: NotPrivileged
            /// </summary>
            [EnumMember(Value = "NotPrivileged")]
            NotPrivileged = 57,

            /// <summary>
            /// Enum AnonForbidden for value: AnonForbidden
            /// </summary>
            [EnumMember(Value = "AnonForbidden")]
            AnonForbidden = 58,

            /// <summary>
            /// Enum AnonForbiddenWorker for value: AnonForbiddenWorker
            /// </summary>
            [EnumMember(Value = "AnonForbiddenWorker")]
            AnonForbiddenWorker = 59,

            /// <summary>
            /// Enum AnonForbiddenUserMod for value: AnonForbiddenUserMod
            /// </summary>
            [EnumMember(Value = "AnonForbiddenUserMod")]
            AnonForbiddenUserMod = 60,

            /// <summary>
            /// Enum NotTrusted for value: NotTrusted
            /// </summary>
            [EnumMember(Value = "NotTrusted")]
            NotTrusted = 61,

            /// <summary>
            /// Enum UntrustedTeamCreation for value: UntrustedTeamCreation
            /// </summary>
            [EnumMember(Value = "UntrustedTeamCreation")]
            UntrustedTeamCreation = 62,

            /// <summary>
            /// Enum UntrustedUnsafeIP for value: UntrustedUnsafeIP
            /// </summary>
            [EnumMember(Value = "UntrustedUnsafeIP")]
            UntrustedUnsafeIP = 63,

            /// <summary>
            /// Enum WorkerMaintenance for value: WorkerMaintenance
            /// </summary>
            [EnumMember(Value = "WorkerMaintenance")]
            WorkerMaintenance = 64,

            /// <summary>
            /// Enum WorkerFlaggedMaintenance for value: WorkerFlaggedMaintenance
            /// </summary>
            [EnumMember(Value = "WorkerFlaggedMaintenance")]
            WorkerFlaggedMaintenance = 65,

            /// <summary>
            /// Enum TooManySameIPs for value: TooManySameIPs
            /// </summary>
            [EnumMember(Value = "TooManySameIPs")]
            TooManySameIPs = 66,

            /// <summary>
            /// Enum WorkerInviteOnly for value: WorkerInviteOnly
            /// </summary>
            [EnumMember(Value = "WorkerInviteOnly")]
            WorkerInviteOnly = 67,

            /// <summary>
            /// Enum UnsafeIP for value: UnsafeIP
            /// </summary>
            [EnumMember(Value = "UnsafeIP")]
            UnsafeIP = 68,

            /// <summary>
            /// Enum TimeoutIP for value: TimeoutIP
            /// </summary>
            [EnumMember(Value = "TimeoutIP")]
            TimeoutIP = 69,

            /// <summary>
            /// Enum TooManyNewIPs for value: TooManyNewIPs
            /// </summary>
            [EnumMember(Value = "TooManyNewIPs")]
            TooManyNewIPs = 70,

            /// <summary>
            /// Enum KudosUpfront for value: KudosUpfront
            /// </summary>
            [EnumMember(Value = "KudosUpfront")]
            KudosUpfront = 71,

            /// <summary>
            /// Enum SharedKeyEmpty for value: SharedKeyEmpty
            /// </summary>
            [EnumMember(Value = "SharedKeyEmpty")]
            SharedKeyEmpty = 72,

            /// <summary>
            /// Enum SharedKeyExpired for value: SharedKeyExpired
            /// </summary>
            [EnumMember(Value = "SharedKeyExpired")]
            SharedKeyExpired = 73,

            /// <summary>
            /// Enum SharedKeyInsufficientKudos for value: SharedKeyInsufficientKudos
            /// </summary>
            [EnumMember(Value = "SharedKeyInsufficientKudos")]
            SharedKeyInsufficientKudos = 74,

            /// <summary>
            /// Enum InvalidJobID for value: InvalidJobID
            /// </summary>
            [EnumMember(Value = "InvalidJobID")]
            InvalidJobID = 75,

            /// <summary>
            /// Enum RequestNotFound for value: RequestNotFound
            /// </summary>
            [EnumMember(Value = "RequestNotFound")]
            RequestNotFound = 76,

            /// <summary>
            /// Enum WorkerNotFound for value: WorkerNotFound
            /// </summary>
            [EnumMember(Value = "WorkerNotFound")]
            WorkerNotFound = 77,

            /// <summary>
            /// Enum TeamNotFound for value: TeamNotFound
            /// </summary>
            [EnumMember(Value = "TeamNotFound")]
            TeamNotFound = 78,

            /// <summary>
            /// Enum FilterNotFound for value: FilterNotFound
            /// </summary>
            [EnumMember(Value = "FilterNotFound")]
            FilterNotFound = 79,

            /// <summary>
            /// Enum UserNotFound for value: UserNotFound
            /// </summary>
            [EnumMember(Value = "UserNotFound")]
            UserNotFound = 80,

            /// <summary>
            /// Enum DuplicateGen for value: DuplicateGen
            /// </summary>
            [EnumMember(Value = "DuplicateGen")]
            DuplicateGen = 81,

            /// <summary>
            /// Enum AbortedGen for value: AbortedGen
            /// </summary>
            [EnumMember(Value = "AbortedGen")]
            AbortedGen = 82,

            /// <summary>
            /// Enum RequestExpired for value: RequestExpired
            /// </summary>
            [EnumMember(Value = "RequestExpired")]
            RequestExpired = 83,

            /// <summary>
            /// Enum TooManyPrompts for value: TooManyPrompts
            /// </summary>
            [EnumMember(Value = "TooManyPrompts")]
            TooManyPrompts = 84,

            /// <summary>
            /// Enum NoValidWorkers for value: NoValidWorkers
            /// </summary>
            [EnumMember(Value = "NoValidWorkers")]
            NoValidWorkers = 85,

            /// <summary>
            /// Enum MaintenanceMode for value: MaintenanceMode
            /// </summary>
            [EnumMember(Value = "MaintenanceMode")]
            MaintenanceMode = 86,

            /// <summary>
            /// Enum TargetAccountFlagged for value: TargetAccountFlagged
            /// </summary>
            [EnumMember(Value = "TargetAccountFlagged")]
            TargetAccountFlagged = 87,

            /// <summary>
            /// Enum SourceAccountFlagged for value: SourceAccountFlagged
            /// </summary>
            [EnumMember(Value = "SourceAccountFlagged")]
            SourceAccountFlagged = 88,

            /// <summary>
            /// Enum FaultWhenKudosReceiving for value: FaultWhenKudosReceiving
            /// </summary>
            [EnumMember(Value = "FaultWhenKudosReceiving")]
            FaultWhenKudosReceiving = 89,

            /// <summary>
            /// Enum FaultWhenKudosSending for value: FaultWhenKudosSending
            /// </summary>
            [EnumMember(Value = "FaultWhenKudosSending")]
            FaultWhenKudosSending = 90,

            /// <summary>
            /// Enum TooFastKudosTransfers for value: TooFastKudosTransfers
            /// </summary>
            [EnumMember(Value = "TooFastKudosTransfers")]
            TooFastKudosTransfers = 91,

            /// <summary>
            /// Enum KudosTransferToAnon for value: KudosTransferToAnon
            /// </summary>
            [EnumMember(Value = "KudosTransferToAnon")]
            KudosTransferToAnon = 92,

            /// <summary>
            /// Enum KudosTransferToSelf for value: KudosTransferToSelf
            /// </summary>
            [EnumMember(Value = "KudosTransferToSelf")]
            KudosTransferToSelf = 93,

            /// <summary>
            /// Enum KudosTransferNotEnough for value: KudosTransferNotEnough
            /// </summary>
            [EnumMember(Value = "KudosTransferNotEnough")]
            KudosTransferNotEnough = 94,

            /// <summary>
            /// Enum NegativeKudosTransfer for value: NegativeKudosTransfer
            /// </summary>
            [EnumMember(Value = "NegativeKudosTransfer")]
            NegativeKudosTransfer = 95,

            /// <summary>
            /// Enum KudosTransferFromAnon for value: KudosTransferFromAnon
            /// </summary>
            [EnumMember(Value = "KudosTransferFromAnon")]
            KudosTransferFromAnon = 96,

            /// <summary>
            /// Enum InvalidAwardUsername for value: InvalidAwardUsername
            /// </summary>
            [EnumMember(Value = "InvalidAwardUsername")]
            InvalidAwardUsername = 97,

            /// <summary>
            /// Enum KudosAwardToAnon for value: KudosAwardToAnon
            /// </summary>
            [EnumMember(Value = "KudosAwardToAnon")]
            KudosAwardToAnon = 98,

            /// <summary>
            /// Enum NotAllowedAwards for value: NotAllowedAwards
            /// </summary>
            [EnumMember(Value = "NotAllowedAwards")]
            NotAllowedAwards = 99,

            /// <summary>
            /// Enum NoWorkerModSelected for value: NoWorkerModSelected
            /// </summary>
            [EnumMember(Value = "NoWorkerModSelected")]
            NoWorkerModSelected = 100,

            /// <summary>
            /// Enum NoUserModSelected for value: NoUserModSelected
            /// </summary>
            [EnumMember(Value = "NoUserModSelected")]
            NoUserModSelected = 101,

            /// <summary>
            /// Enum NoHordeModSelected for value: NoHordeModSelected
            /// </summary>
            [EnumMember(Value = "NoHordeModSelected")]
            NoHordeModSelected = 102,

            /// <summary>
            /// Enum NoTeamModSelected for value: NoTeamModSelected
            /// </summary>
            [EnumMember(Value = "NoTeamModSelected")]
            NoTeamModSelected = 103,

            /// <summary>
            /// Enum NoFilterModSelected for value: NoFilterModSelected
            /// </summary>
            [EnumMember(Value = "NoFilterModSelected")]
            NoFilterModSelected = 104,

            /// <summary>
            /// Enum NoSharedKeyModSelected for value: NoSharedKeyModSelected
            /// </summary>
            [EnumMember(Value = "NoSharedKeyModSelected")]
            NoSharedKeyModSelected = 105,

            /// <summary>
            /// Enum BadRequest for value: BadRequest
            /// </summary>
            [EnumMember(Value = "BadRequest")]
            BadRequest = 106,

            /// <summary>
            /// Enum Forbidden for value: Forbidden
            /// </summary>
            [EnumMember(Value = "Forbidden")]
            Forbidden = 107,

            /// <summary>
            /// Enum Locked for value: Locked
            /// </summary>
            [EnumMember(Value = "Locked")]
            Locked = 108,

            /// <summary>
            /// Enum ControlNetMismatch for value: ControlNetMismatch
            /// </summary>
            [EnumMember(Value = "ControlNetMismatch")]
            ControlNetMismatch = 109,

            /// <summary>
            /// Enum HiResFixMismatch for value: HiResFixMismatch
            /// </summary>
            [EnumMember(Value = "HiResFixMismatch")]
            HiResFixMismatch = 110,

            /// <summary>
            /// Enum TooManyLoras for value: TooManyLoras
            /// </summary>
            [EnumMember(Value = "TooManyLoras")]
            TooManyLoras = 111,

            /// <summary>
            /// Enum BadLoraVersion for value: BadLoraVersion
            /// </summary>
            [EnumMember(Value = "BadLoraVersion")]
            BadLoraVersion = 112,

            /// <summary>
            /// Enum TooManyTIs for value: TooManyTIs
            /// </summary>
            [EnumMember(Value = "TooManyTIs")]
            TooManyTIs = 113,

            /// <summary>
            /// Enum BetaAnonForbidden for value: BetaAnonForbidden
            /// </summary>
            [EnumMember(Value = "BetaAnonForbidden")]
            BetaAnonForbidden = 114,

            /// <summary>
            /// Enum BetaComparisonFault for value: BetaComparisonFault
            /// </summary>
            [EnumMember(Value = "BetaComparisonFault")]
            BetaComparisonFault = 115,

            /// <summary>
            /// Enum BadCFGDecimals for value: BadCFGDecimals
            /// </summary>
            [EnumMember(Value = "BadCFGDecimals")]
            BadCFGDecimals = 116,

            /// <summary>
            /// Enum BadCFGNumber for value: BadCFGNumber
            /// </summary>
            [EnumMember(Value = "BadCFGNumber")]
            BadCFGNumber = 117,

            /// <summary>
            /// Enum BadClientAgent for value: BadClientAgent
            /// </summary>
            [EnumMember(Value = "BadClientAgent")]
            BadClientAgent = 118,

            /// <summary>
            /// Enum SpecialMissingPayload for value: SpecialMissingPayload
            /// </summary>
            [EnumMember(Value = "SpecialMissingPayload")]
            SpecialMissingPayload = 119,

            /// <summary>
            /// Enum SpecialForbidden for value: SpecialForbidden
            /// </summary>
            [EnumMember(Value = "SpecialForbidden")]
            SpecialForbidden = 120,

            /// <summary>
            /// Enum SpecialMissingUsername for value: SpecialMissingUsername
            /// </summary>
            [EnumMember(Value = "SpecialMissingUsername")]
            SpecialMissingUsername = 121,

            /// <summary>
            /// Enum SpecialModelNeedsSpecialUser for value: SpecialModelNeedsSpecialUser
            /// </summary>
            [EnumMember(Value = "SpecialModelNeedsSpecialUser")]
            SpecialModelNeedsSpecialUser = 122,

            /// <summary>
            /// Enum SpecialFieldNeedsSpecialUser for value: SpecialFieldNeedsSpecialUser
            /// </summary>
            [EnumMember(Value = "SpecialFieldNeedsSpecialUser")]
            SpecialFieldNeedsSpecialUser = 123,

            /// <summary>
            /// Enum Img2ImgMismatch for value: Img2ImgMismatch
            /// </summary>
            [EnumMember(Value = "Img2ImgMismatch")]
            Img2ImgMismatch = 124,

            /// <summary>
            /// Enum TilingMismatch for value: TilingMismatch
            /// </summary>
            [EnumMember(Value = "TilingMismatch")]
            TilingMismatch = 125,

            /// <summary>
            /// Enum EducationCannotSendKudos for value: EducationCannotSendKudos
            /// </summary>
            [EnumMember(Value = "EducationCannotSendKudos")]
            EducationCannotSendKudos = 126,

            /// <summary>
            /// Enum InvalidPriorityUsername for value: InvalidPriorityUsername
            /// </summary>
            [EnumMember(Value = "InvalidPriorityUsername")]
            InvalidPriorityUsername = 127,

            /// <summary>
            /// Enum OnlyServiceAccountProxy for value: OnlyServiceAccountProxy
            /// </summary>
            [EnumMember(Value = "OnlyServiceAccountProxy")]
            OnlyServiceAccountProxy = 128,

            /// <summary>
            /// Enum RequiresTrust for value: RequiresTrust
            /// </summary>
            [EnumMember(Value = "RequiresTrust")]
            RequiresTrust = 129

        }


        /// <summary>
        /// The return code for this error. See: https://github.com/Haidra-Org/AI-Horde/blob/main/README_return_codes.md
        /// </summary>
        /// <value>The return code for this error. See: https://github.com/Haidra-Org/AI-Horde/blob/main/README_return_codes.md</value>
        [DataMember(Name = "rc", IsRequired = true, EmitDefaultValue = true)]
        public RcEnum Rc { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestValidationError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestValidationError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestValidationError" /> class.
        /// </summary>
        /// <param name="message">The error message for this status code..</param>
        /// <param name="rc">The return code for this error. See: https://github.com/Haidra-Org/AI-Horde/blob/main/README_return_codes.md (required).</param>
        /// <param name="errors">errors.</param>
        public RequestValidationError(string message = default(string), RcEnum rc = default(RcEnum), Dictionary<string, string> errors = default(Dictionary<string, string>))
        {
            this.Rc = rc;
            this.Message = message;
            this.Errors = errors;
        }

        /// <summary>
        /// The error message for this status code.
        /// </summary>
        /// <value>The error message for this status code.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", EmitDefaultValue = false)]
        public Dictionary<string, string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestValidationError {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Rc: ").Append(Rc).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as RequestValidationError);
        }

        /// <summary>
        /// Returns true if RequestValidationError instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestValidationError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestValidationError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Rc == input.Rc ||
                    this.Rc.Equals(input.Rc)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rc.GetHashCode();
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
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