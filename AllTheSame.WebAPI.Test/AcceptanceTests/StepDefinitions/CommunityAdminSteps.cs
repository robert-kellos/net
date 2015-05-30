﻿using System.Collections.Generic;
using AllTheSame.Common.Extensions;
using AllTheSame.Common.Helpers;
using AllTheSame.Entity.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using AllTheSame.Common.Logging;
using System.Net.Http;
using System.Web.Http.Results;
using System.Net;
using System;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using AllTheSame.WebAPI.Models;

namespace AllTheSame.WebAPI.Test.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CommunityAdminSteps : BaseServiceTest//AuthenticatedTest //- Allows automatic fetching of token for each get call
    {
        #region Local Properties/Fields
        //
        private const string HttpResponseKey = "http_response";

        private const string GetListKey = "communityAdmin_get_list";
        private const string GetItemKey = "communityAdmin_get_item";
        private const string AddItemKey = "communityAdmin_add_item";
        private const string EditItemKey = "communityAdmin_edit_item";
        private const string DeleteItemKey = "communityAdmin_delete_item";
        private const string ExistsItemKey = "communityAdmin_exists_item";

        private CommunityAdmin _getItem;
        private CommunityAdmin _addItem;
        private CommunityAdmin _editItem;
        private CommunityAdmin _deleteItem;

        private string _getId = "-1";
        private int _getIdValue = -1;

        private string _editId = "-1";
        private int _editIdValue = -1;

        private string _addedId = "-1";
        private int _addedIdValue = -1;

        private string _deletedId = "-1";
        private int _deletedIdValue = -1;

        private string _existsId = "-1";
        private int _existsIdValue = -1;

        private string _line1 = "";
        private string _line2 = "";
        private string _city = "";
        private string _state = "";
        private string _country = "";
        private string _postalCode = "";
        //
        #endregion Local Properties/Fields

        public override string Uri
        {
            get { return "/api/CommunityAdmin"; }
        }

        #region Post - add a new item by a populated item
        //
        [Given(@"the following CommunityAdmin Add input")]
        public void GivenTheFollowingCommunityAdminAddInput(Table table)
        {
            Assert.IsNotNull(table);
            foreach (var row in table.Rows)
            {
                //_line1 = row["Line1"];
                //_line2 = row["Line2"];
                //_city = row["City"];
                //_state = row["State"];
                //_country = row["Country"];
                //_postalCode = row["PostalCode"];

                break;
            }
            //Assert.IsNotNull(_line1);
            //Assert.IsNotNull(_city);
            //Assert.IsNotNull(_city.IsValidEmailAddress());

            _addItem = new CommunityAdmin()
            {
                //Line1 = _line1,
                //Line2 = _line2,
                //City = _city,
                //State = _state,
                //Country = _country,
                //PostalCode = _postalCode,

                CreatedOn = DateTime.UtcNow,
            };
        }

        [When(@"I call the add CommunityAdmin Post api endpoint to add a communityAdmin")]
        public void WhenICallTheAddCommunityAdminPostApiEndpointToAddACommunityAdmin()
        {
            var response = default(HttpResponseMessage);
            var error = default(AggregateException);

            PostAsync(_addItem).ContinueWith(
                t =>
                {
                    if (t.IsCompleted)
                    {
                        if (t.Result != null)
                            response = (t.Result as HttpResponseMessage);
                    }

                    if (t.IsFaulted)
                    {
                        error = t.Exception;
                        Audit.Log.Error("POST Task Exception ::", error);
                    }
                }
            ).Wait();

            Assert.IsNotNull(response);
            ScenarioContext.Current[AddItemKey] = response;
        }

        [Then(@"the add result should be a CommunityAdmin Id")]
        public void ThenTheAddResultShouldBeACommunityAdminId()
        {
            var response = default(HttpResponseMessage);
            var error = default(AggregateException);

            PostAsync(_addItem).ContinueWith(
                t =>
                {
                    if (t.IsCompleted)
                    {
                        if (t.Result != null)
                            response = (t.Result as HttpResponseMessage);
                    }

                    if (t.IsFaulted)
                    {
                        error = t.Exception;
                        Audit.Log.Error("POST Task Exception ::", error);
                    }
                }
            ).Wait();

            Assert.IsNotNull(response);
            ScenarioContext.Current[AddItemKey] = response;
        }

        [Then(@"the add result should be a Item Id")]
        public void ThenTheAddResultShouldBeAItemId()
        {
            _addedIdValue = -1;

            //grab the resulting added item
            var result = PostResponse<CommunityAdmin, CommunityAdmin>(_addItem);
            if (result != null)
            {

                _addedIdValue = result.Id;
                Assert.IsTrue(_addedIdValue > 0);

                ////validate values changed
                //Assert.AreEqual(_addItem.FirstName, result.FirstName);
                //Assert.AreEqual(_addItem.LastName, result.LastName);
                //Assert.AreEqual(_addItem.Email, result.Email);
                //Assert.AreEqual(_addItem.MobilePhone, result.MobilePhone);
            }

            var response = (ScenarioContext.Current[AddItemKey] as HttpResponseMessage);

            Assert.IsNotNull(response);
            Assert.IsTrue(response.StatusCode == HttpStatusCode.Created);
        }

        //
        #endregion Post - add a new item by a populated item

        #region Get - get a list of items
        //
        [When(@"I call the CommunityAdmin Get api endpoint")]
        public void WhenICallTheCommunityAdminGetApiEndpoint()
        {
            ScenarioContext.Current[GetListKey] = GetResponse<IList<CommunityAdmin>>();
        }

        [Then(@"the get result should be a list of communityAdmins")]
        public void ThenTheGetResultShouldBeAListOfCommunityAdmins()
        {
            //
            var list = ScenarioContext.Current[GetListKey];
            Assert.IsNotNull(list);
            Assert.IsNotNull(list as IList<CommunityAdmin>);
        }

        //
        #endregion Get - get a list of items

        #region Get - get an item by Id
        //
        [Given(@"the following CommunityAdmin GetById input")]
        public void GivenTheFollowingCommunityAdminGetByIdInput(Table table)
        {
            var response = default(HttpResponseMessage);
            var error = default(AggregateException);

            PostAsync(_addItem).ContinueWith(
                t =>
                {
                    if (t.IsCompleted)
                    {
                        if (t.Result != null)
                            response = (t.Result as HttpResponseMessage);
                    }

                    if (t.IsFaulted)
                    {
                        error = t.Exception;
                        Audit.Log.Error("POST Task Exception ::", error);
                    }
                }
            ).Wait();

            Assert.IsNotNull(response);
            ScenarioContext.Current[AddItemKey] = response;
        }

        //
        #endregion Post - add a new item by a populated item

        #region Put - edit an existing item by a populated item, and its Id
        //
        [Given(@"the following CommunityAdmin Edit input")]
        public void GivenTheFollowingCommunityAdminEditInput(Table table)
        {
            //
        }

        [When(@"I call the edit CommunityAdmin Put api endpoint to edit a communityAdmin")]
        public void WhenICallTheEditCommunityAdminPutApiEndpointToEditACommunityAdmin()
        {
            //
        }

        [Then(@"the edit result should be an updated CommunityAdmin")]
        public void ThenTheEditResultShouldBeAnUpdatedCommunityAdmin()
        {
            //
        }

        //
        #endregion Put - edit an existing item by a populated item, and its Id

        #region Post - delete an existing item by a populated item
        //
        [Given(@"the following CommunityAdmin Delete input")]
        public void GivenTheFollowingCommunityAdminDeleteInput(Table table)
        {
            //
        }

        [When(@"I call the delete CommunityAdmin Post api endpoint to delete a communityAdmin")]
        public void WhenICallTheDeleteCommunityAdminPostApiEndpointToDeleteACommunityAdmin()
        {
            //
        }

        [Then(@"the delete result should be an deleted CommunityAdmin")]
        public void ThenTheDeleteResultShouldBeAnDeletedCommunityAdmin()
        {
            //
        }

        //
        #endregion Post - delete an existing item by a populated item

        #region Get - Exists, verify Exists function checks and return a valid bool for exists or not
        //
        [Given(@"the following CommunityAdmin Id input")]
        public void GivenTheFollowingCommunityAdminIdInput(Table table)
        {
            Assert.IsNotNull(table);

            foreach (var row in table.Rows)
            {
                _existsId = row["Id"]; 

                break;
            }
            Assert.IsNotNull(_existsId);
            _existsIdValue = ConvertToIntValue(_existsId);

            Assert.IsTrue(_existsIdValue > 0);
        }

        [When(@"I call the CommunityAdmin Exists Get api endpoint by Id to verify if it exists")]
        public void WhenICallTheCommunityAdminExistsGetApiEndpointByIdToVerifyIfItExists()
        {
            ScenarioContext.Current[ExistsItemKey] = GetResponseExists<bool>(_existsIdValue);
        }

        [Then(@"the CommunityAdmin exists result should be bool true or false")]
        public void ThenTheCommunityAdminExistsResultShouldBeBoolTrueOrFalse()
        {
            var result = Convert.ToBoolean(ScenarioContext.Current[ExistsItemKey]);

            //call manually to verify Exists returned correctly
            var item = GetResponseById<CommunityAdmin>(_existsIdValue);

            var truth = (item != null && item.Id == _existsIdValue);
            Assert.IsTrue(truth == result);
        }

        //
        #endregion Get - Exists, verify Exists function checks and return a valid bool for exists or not

        //

        #region helpers
        //
        public int ConvertToIntValue(string value)
        {
            var result = -1;

            int.TryParse(value, out result);

            return result;
        }
        //
        #endregion helpers
    }
}