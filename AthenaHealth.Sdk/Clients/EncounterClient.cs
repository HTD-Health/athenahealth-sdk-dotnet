﻿using System;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class EncounterClient : IEncounterClient
    {
        private readonly IConnection _connection;

        public EncounterClient(IConnection connection)
        {
            _connection = connection;
        }

        public async Task<Encounter> GetById(int encounterId)
        {
            Encounter[] result = await _connection.Get<Encounter[]>($"{_connection.PracticeId}/chart/encounter/{encounterId}");
            return result.FirstOrThrowException();
        }

        /// <summary>
        /// The HTML Summary for an encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public async Task<EncounterSummary> GetSummary(int encounterId, GetEncounterSummaryFilter filter = null)
        {
            return await _connection.Get<EncounterSummary>($"{_connection.PracticeId}/chart/encounters/{encounterId}/summary", filter);
        }

        /// <summary>
        /// The list of diagnoses for this encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <returns></returns>
        public async Task<Diagnose[]> GetDiagnoses(int encounterId)
        {
            return await _connection.Get<Diagnose[]>($"{_connection.PracticeId}/chart/encounter/{encounterId}/diagnoses");
        }

        public async Task<Diagnose> CreateDiagnoses(int encounterId, CreateDiagnoses model)
        {
            return await _connection.Post<Diagnose>($"{_connection.PracticeId}/chart/encounter/{encounterId}/diagnoses", null, model);
        }

        public Task DeleteDiagnoses(int encounterId, int diagnosisId)
        {
            return _connection.Delete<DeleteResponse>(
                $"{_connection.PracticeId}/chart/encounter/{encounterId}/diagnoses/{diagnosisId}"
            );
        }
    }
}