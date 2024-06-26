/*
 * AI Horde
 *
 * The API documentation for the AI Horde
 *
 * The version of the OpenAPI document: 2.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Knedlex.StableHorde.Api.Client;
using Knedlex.StableHorde.Api.Api;
// uncomment below to import models
//using Knedlex.StableHorde.Api.Model;

namespace Knedlex.StableHorde.Api.Test.Api
{
    /// <summary>
    ///  Class for testing V2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class V2ApiTests : IDisposable
    {
        private V2Api instance;

        public V2ApiTests()
        {
            instance = new V2Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of V2Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' V2Api
            //Assert.IsType<V2Api>(instance);
        }

        /// <summary>
        /// Test DeleteFilterSingle
        /// </summary>
        [Fact]
        public void DeleteFilterSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteFilterSingle(filterId, apikey, clientAgent, xFields);
            //Assert.IsType<SimpleResponse>(response);
        }

        /// <summary>
        /// Test DeleteImageAsyncStatus
        /// </summary>
        [Fact]
        public void DeleteImageAsyncStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteImageAsyncStatus(id, clientAgent, xFields);
            //Assert.IsType<RequestStatusStable>(response);
        }

        /// <summary>
        /// Test DeleteInterrogationStatus
        /// </summary>
        [Fact]
        public void DeleteInterrogationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteInterrogationStatus(id, clientAgent, xFields);
            //Assert.IsType<InterrogationStatus>(response);
        }

        /// <summary>
        /// Test DeleteOperationsBlockWorkerIp
        /// </summary>
        [Fact]
        public void DeleteOperationsBlockWorkerIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workerId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteOperationsBlockWorkerIp(workerId, apikey, clientAgent, xFields);
            //Assert.IsType<SimpleResponse>(response);
        }

        /// <summary>
        /// Test DeleteOperationsIp
        /// </summary>
        [Fact]
        public void DeleteOperationsIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //DeleteTimeoutIPInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteOperationsIp(apikey, payload, clientAgent, xFields);
            //Assert.IsType<SimpleResponse>(response);
        }

        /// <summary>
        /// Test DeleteSharedKeySingle
        /// </summary>
        [Fact]
        public void DeleteSharedKeySingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sharedkeyId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteSharedKeySingle(sharedkeyId, apikey, clientAgent, xFields);
            //Assert.IsType<SimpleResponse>(response);
        }

        /// <summary>
        /// Test DeleteTeamSingle
        /// </summary>
        [Fact]
        public void DeleteTeamSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string clientAgent = null;
            //string apikey = null;
            //string xFields = null;
            //var response = instance.DeleteTeamSingle(teamId, clientAgent, apikey, xFields);
            //Assert.IsType<DeletedTeam>(response);
        }

        /// <summary>
        /// Test DeleteTextAsyncStatus
        /// </summary>
        [Fact]
        public void DeleteTextAsyncStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteTextAsyncStatus(id, clientAgent, xFields);
            //Assert.IsType<RequestStatusKobold>(response);
        }

        /// <summary>
        /// Test DeleteWorkerSingle
        /// </summary>
        [Fact]
        public void DeleteWorkerSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workerId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.DeleteWorkerSingle(workerId, apikey, clientAgent, xFields);
            //Assert.IsType<DeletedWorker>(response);
        }

        /// <summary>
        /// Test GetFilterRegex
        /// </summary>
        [Fact]
        public void GetFilterRegexTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //string clientAgent = null;
            //int? filterType = null;
            //string xFields = null;
            //var response = instance.GetFilterRegex(apikey, clientAgent, filterType, xFields);
            //Assert.IsType<List<FilterRegex>>(response);
        }

        /// <summary>
        /// Test GetFilterSingle
        /// </summary>
        [Fact]
        public void GetFilterSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetFilterSingle(filterId, apikey, clientAgent, xFields);
            //Assert.IsType<List<FilterDetails>>(response);
        }

        /// <summary>
        /// Test GetFilters
        /// </summary>
        [Fact]
        public void GetFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //string clientAgent = null;
            //int? filterType = null;
            //string contains = null;
            //string xFields = null;
            //var response = instance.GetFilters(apikey, clientAgent, filterType, contains, xFields);
            //Assert.IsType<List<FilterDetails>>(response);
        }

        /// <summary>
        /// Test GetFindUser
        /// </summary>
        [Fact]
        public void GetFindUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetFindUser(apikey, clientAgent, xFields);
            //Assert.IsType<UserDetails>(response);
        }

        /// <summary>
        /// Test GetHeartbeat
        /// </summary>
        [Fact]
        public void GetHeartbeatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //instance.GetHeartbeat(clientAgent);
        }

        /// <summary>
        /// Test GetHordeLoad
        /// </summary>
        [Fact]
        public void GetHordeLoadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetHordeLoad(clientAgent, xFields);
            //Assert.IsType<HordePerformance>(response);
        }

        /// <summary>
        /// Test GetHordeModes
        /// </summary>
        [Fact]
        public void GetHordeModesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //string xFields = null;
            //var response = instance.GetHordeModes(apikey, xFields);
            //Assert.IsType<HordeModes>(response);
        }

        /// <summary>
        /// Test GetHordeNews
        /// </summary>
        [Fact]
        public void GetHordeNewsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetHordeNews(clientAgent, xFields);
            //Assert.IsType<List<Newspiece>>(response);
        }

        /// <summary>
        /// Test GetImageAsyncCheck
        /// </summary>
        [Fact]
        public void GetImageAsyncCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetImageAsyncCheck(id, clientAgent, xFields);
            //Assert.IsType<RequestStatusCheck>(response);
        }

        /// <summary>
        /// Test GetImageAsyncStatus
        /// </summary>
        [Fact]
        public void GetImageAsyncStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetImageAsyncStatus(id, clientAgent, xFields);
            //Assert.IsType<RequestStatusStable>(response);
        }

        /// <summary>
        /// Test GetImageHordeStatsModels
        /// </summary>
        [Fact]
        public void GetImageHordeStatsModelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetImageHordeStatsModels(clientAgent, xFields);
            //Assert.IsType<ImgModelStats>(response);
        }

        /// <summary>
        /// Test GetImageHordeStatsTotals
        /// </summary>
        [Fact]
        public void GetImageHordeStatsTotalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetImageHordeStatsTotals(clientAgent, xFields);
            //Assert.IsType<StatsImgTotals>(response);
        }

        /// <summary>
        /// Test GetInterrogationStatus
        /// </summary>
        [Fact]
        public void GetInterrogationStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetInterrogationStatus(id, clientAgent, xFields);
            //Assert.IsType<InterrogationStatus>(response);
        }

        /// <summary>
        /// Test GetModelSingle
        /// </summary>
        [Fact]
        public void GetModelSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string modelName = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetModelSingle(modelName, clientAgent, xFields);
            //Assert.IsType<ActiveModel>(response);
        }

        /// <summary>
        /// Test GetModels
        /// </summary>
        [Fact]
        public void GetModelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string type = null;
            //int? minCount = null;
            //int? maxCount = null;
            //string xFields = null;
            //var response = instance.GetModels(clientAgent, type, minCount, maxCount, xFields);
            //Assert.IsType<List<ActiveModel>>(response);
        }

        /// <summary>
        /// Test GetOperationsIp
        /// </summary>
        [Fact]
        public void GetOperationsIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetOperationsIp(apikey, clientAgent, xFields);
            //Assert.IsType<List<IPTimeout>>(response);
        }

        /// <summary>
        /// Test GetOperationsIpSingle
        /// </summary>
        [Fact]
        public void GetOperationsIpSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ipaddr = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetOperationsIpSingle(ipaddr, apikey, clientAgent, xFields);
            //Assert.IsType<List<IPTimeout>>(response);
        }

        /// <summary>
        /// Test GetSharedKeySingle
        /// </summary>
        [Fact]
        public void GetSharedKeySingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sharedkeyId = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetSharedKeySingle(sharedkeyId, clientAgent, xFields);
            //Assert.IsType<SharedKeyDetails>(response);
        }

        /// <summary>
        /// Test GetTeamSingle
        /// </summary>
        [Fact]
        public void GetTeamSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetTeamSingle(teamId, apikey, clientAgent, xFields);
            //Assert.IsType<TeamDetails>(response);
        }

        /// <summary>
        /// Test GetTeams
        /// </summary>
        [Fact]
        public void GetTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetTeams(clientAgent, xFields);
            //Assert.IsType<List<TeamDetails>>(response);
        }

        /// <summary>
        /// Test GetTextAsyncStatus
        /// </summary>
        [Fact]
        public void GetTextAsyncStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetTextAsyncStatus(id, clientAgent, xFields);
            //Assert.IsType<RequestStatusKobold>(response);
        }

        /// <summary>
        /// Test GetTextHordeStatsModels
        /// </summary>
        [Fact]
        public void GetTextHordeStatsModelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetTextHordeStatsModels(clientAgent, xFields);
            //Assert.IsType<TxtModelStats>(response);
        }

        /// <summary>
        /// Test GetTextHordeStatsTotals
        /// </summary>
        [Fact]
        public void GetTextHordeStatsTotalsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetTextHordeStatsTotals(clientAgent, xFields);
            //Assert.IsType<StatsTxtTotals>(response);
        }

        /// <summary>
        /// Test GetUserSingle
        /// </summary>
        [Fact]
        public void GetUserSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetUserSingle(userId, apikey, clientAgent, xFields);
            //Assert.IsType<UserDetails>(response);
        }

        /// <summary>
        /// Test GetUsers
        /// </summary>
        [Fact]
        public void GetUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientAgent = null;
            //int? page = null;
            //string sort = null;
            //string xFields = null;
            //var response = instance.GetUsers(clientAgent, page, sort, xFields);
            //Assert.IsType<UserDetails>(response);
        }

        /// <summary>
        /// Test GetWorkerSingle
        /// </summary>
        [Fact]
        public void GetWorkerSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workerId = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.GetWorkerSingle(workerId, apikey, clientAgent, xFields);
            //Assert.IsType<WorkerDetails>(response);
        }

        /// <summary>
        /// Test GetWorkers
        /// </summary>
        [Fact]
        public void GetWorkersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //string clientAgent = null;
            //string type = null;
            //string xFields = null;
            //var response = instance.GetWorkers(apikey, clientAgent, type, xFields);
            //Assert.IsType<List<WorkerDetails>>(response);
        }

        /// <summary>
        /// Test PatchFilterSingle
        /// </summary>
        [Fact]
        public void PatchFilterSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filterId = null;
            //string apikey = null;
            //PatchExistingFilter payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PatchFilterSingle(filterId, apikey, payload, clientAgent, xFields);
            //Assert.IsType<FilterDetails>(response);
        }

        /// <summary>
        /// Test PatchSharedKeySingle
        /// </summary>
        [Fact]
        public void PatchSharedKeySingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sharedkeyId = null;
            //string apikey = null;
            //SharedKeyInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PatchSharedKeySingle(sharedkeyId, apikey, payload, clientAgent, xFields);
            //Assert.IsType<SharedKeyDetails>(response);
        }

        /// <summary>
        /// Test PatchTeamSingle
        /// </summary>
        [Fact]
        public void PatchTeamSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamId = null;
            //ModifyTeamInput payload = null;
            //string apikey = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PatchTeamSingle(teamId, payload, apikey, clientAgent, xFields);
            //Assert.IsType<ModifyTeam>(response);
        }

        /// <summary>
        /// Test PostAesthetics
        /// </summary>
        [Fact]
        public void PostAestheticsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AestheticsPayload payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostAesthetics(id, payload, clientAgent, xFields);
            //Assert.IsType<GenerationSubmitted>(response);
        }

        /// <summary>
        /// Test PostAwardKudos
        /// </summary>
        [Fact]
        public void PostAwardKudosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PostAwardKudosRequest payload = null;
            //string xFields = null;
            //var response = instance.PostAwardKudos(apikey, payload, xFields);
            //Assert.IsType<KudosAwarded>(response);
        }

        /// <summary>
        /// Test PostFilters
        /// </summary>
        [Fact]
        public void PostFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PostFiltersRequest payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostFilters(apikey, payload, clientAgent, xFields);
            //Assert.IsType<FilterPromptSuspicion>(response);
        }

        /// <summary>
        /// Test PostImageAsyncGenerate
        /// </summary>
        [Fact]
        public void PostImageAsyncGenerateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //GenerationInputStable payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostImageAsyncGenerate(apikey, payload, clientAgent, xFields);
            //Assert.IsType<RequestAsync>(response);
        }

        /// <summary>
        /// Test PostImageJobPop
        /// </summary>
        [Fact]
        public void PostImageJobPopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PopInputStable payload = null;
            //string xFields = null;
            //var response = instance.PostImageJobPop(apikey, payload, xFields);
            //Assert.IsType<GenerationPayloadStable>(response);
        }

        /// <summary>
        /// Test PostImageJobSubmit
        /// </summary>
        [Fact]
        public void PostImageJobSubmitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //SubmitInputStable payload = null;
            //string xFields = null;
            //var response = instance.PostImageJobSubmit(apikey, payload, xFields);
            //Assert.IsType<GenerationSubmitted>(response);
        }

        /// <summary>
        /// Test PostInterrogate
        /// </summary>
        [Fact]
        public void PostInterrogateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //ModelInterrogationInputStable payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostInterrogate(apikey, payload, clientAgent, xFields);
            //Assert.IsType<RequestInterrogationResponse>(response);
        }

        /// <summary>
        /// Test PostInterrogatePop
        /// </summary>
        [Fact]
        public void PostInterrogatePopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //InterrogationPopInput payload = null;
            //string xFields = null;
            //var response = instance.PostInterrogatePop(apikey, payload, xFields);
            //Assert.IsType<InterrogationPopPayload>(response);
        }

        /// <summary>
        /// Test PostInterrogateSubmit
        /// </summary>
        [Fact]
        public void PostInterrogateSubmitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PostInterrogateSubmitRequest payload = null;
            //string xFields = null;
            //var response = instance.PostInterrogateSubmit(apikey, payload, xFields);
            //Assert.IsType<GenerationSubmitted>(response);
        }

        /// <summary>
        /// Test PostOperationsIp
        /// </summary>
        [Fact]
        public void PostOperationsIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //AddTimeoutIPInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostOperationsIp(apikey, payload, clientAgent, xFields);
            //Assert.IsType<SimpleResponse>(response);
        }

        /// <summary>
        /// Test PostTeams
        /// </summary>
        [Fact]
        public void PostTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //CreateTeamInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostTeams(apikey, payload, clientAgent, xFields);
            //Assert.IsType<ModifyTeam>(response);
        }

        /// <summary>
        /// Test PostTextAsyncGenerate
        /// </summary>
        [Fact]
        public void PostTextAsyncGenerateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //GenerationInputKobold payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostTextAsyncGenerate(apikey, payload, clientAgent, xFields);
            //Assert.IsType<RequestAsync>(response);
        }

        /// <summary>
        /// Test PostTextJobPop
        /// </summary>
        [Fact]
        public void PostTextJobPopTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PopInputKobold payload = null;
            //string xFields = null;
            //var response = instance.PostTextJobPop(apikey, payload, xFields);
            //Assert.IsType<GenerationPayload>(response);
        }

        /// <summary>
        /// Test PostTextJobSubmit
        /// </summary>
        [Fact]
        public void PostTextJobSubmitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //SubmitInputKobold payload = null;
            //string xFields = null;
            //var response = instance.PostTextJobSubmit(apikey, payload, xFields);
            //Assert.IsType<GenerationSubmitted>(response);
        }

        /// <summary>
        /// Test PostTransferKudos
        /// </summary>
        [Fact]
        public void PostTransferKudosTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PostAwardKudosRequest payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PostTransferKudos(apikey, payload, clientAgent, xFields);
            //Assert.IsType<KudosTransferred>(response);
        }

        /// <summary>
        /// Test PutFilters
        /// </summary>
        [Fact]
        public void PutFiltersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PutNewFilter payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PutFilters(apikey, payload, clientAgent, xFields);
            //Assert.IsType<FilterDetails>(response);
        }

        /// <summary>
        /// Test PutHordeModes
        /// </summary>
        [Fact]
        public void PutHordeModesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //PutHordeModesRequest payload = null;
            //string xFields = null;
            //var response = instance.PutHordeModes(apikey, payload, xFields);
            //Assert.IsType<HordeModes>(response);
        }

        /// <summary>
        /// Test PutOperationsBlockWorkerIp
        /// </summary>
        [Fact]
        public void PutOperationsBlockWorkerIpTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workerId = null;
            //string apikey = null;
            //AddWorkerTimeout payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PutOperationsBlockWorkerIp(workerId, apikey, payload, clientAgent, xFields);
            //Assert.IsType<SimpleResponse>(response);
        }

        /// <summary>
        /// Test PutSharedKey
        /// </summary>
        [Fact]
        public void PutSharedKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string apikey = null;
            //SharedKeyInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PutSharedKey(apikey, payload, clientAgent, xFields);
            //Assert.IsType<SharedKeyDetails>(response);
        }

        /// <summary>
        /// Test PutUserSingle
        /// </summary>
        [Fact]
        public void PutUserSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string apikey = null;
            //ModifyUserInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PutUserSingle(userId, apikey, payload, clientAgent, xFields);
            //Assert.IsType<ModifyUser>(response);
        }

        /// <summary>
        /// Test PutWorkerSingle
        /// </summary>
        [Fact]
        public void PutWorkerSingleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workerId = null;
            //string apikey = null;
            //ModifyWorkerInput payload = null;
            //string clientAgent = null;
            //string xFields = null;
            //var response = instance.PutWorkerSingle(workerId, apikey, payload, clientAgent, xFields);
            //Assert.IsType<ModifyWorker>(response);
        }
    }
}
