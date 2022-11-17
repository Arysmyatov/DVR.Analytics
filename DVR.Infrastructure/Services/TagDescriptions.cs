using DVR.Contracts.Entities;

namespace DVR.Infrastructure.Services
{
    public static class TagGroups
    {
        public static IEnumerable<TagGroup> GetAllTagGroups()
        {
            return new TagGroup[] {
                new TagGroup {
                    Name = "Architecture",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "Design Patterns",
                            Technologies = new string[] { "Design Patterns"}
                        },
                        new TagDescription  {
                            Name = "RESTful API",
                            Technologies = new string[] { "RESTful"}
                        },
                        new TagDescription  {
                            Name = "SOA",
                            Technologies = new string[] { "SOA architecture"}
                        },
                        new TagDescription  {
                            Name = "microservices",
                            Technologies = new string[] { "microservices"}
                        },
                        new TagDescription  {
                            Name = "SPA(Single Page Application)",
                            Technologies = new string[] { "SPA application", "Single Page Application", "Single-Page Application"}
                        },
                        new TagDescription  {
                            Name = "CQRS",
                            Technologies = new string[] { "CQRS"}
                        },
                        new TagDescription  {
                            Name = "DDD",
                            Technologies = new string[] { "DDD"}
                        },
                        new TagDescription  {
                            Name = "BDD",
                            Technologies = new string[] { "BDD"}
                        },
                        new TagDescription  {
                            Name = "OOA&D",
                            Technologies = new string[] { "OOA"}
                        },
                        new TagDescription  {
                            Name = "TDD",
                            Technologies = new string[] { "TDD"}
                        },
                        new TagDescription  {
                            Name = "BDD",
                            Technologies = new string[] { "BDD ", "BDD,", "BDD."}
                        },
                        new TagDescription  {
                            Name = "SOLID",
                            Technologies = new string[] { "SOLID principles", "SOLID ", "SOLID,", "SOLID;"}
                        },
                        new TagDescription  {
                            Name = "N-Tier",
                            Technologies = new string[] { "N-Tier", "N-Tier,"}
                        },
                        new TagDescription  {
                            Name = "Onion",
                            Technologies = new string[] { "Onion",}
                        },
                        new TagDescription  {
                            Name = "Machine Learning",
                            Technologies = new string[] { "Machine Learning"}
                        },
                        new TagDescription  {
                            Name = "Big Data",
                            Technologies = new string[] { "Big Data"}
                        },
                        new TagDescription  {
                            Name = "Windows Azure",
                            Technologies = new string[] { "Azure"}
                        },
                        new TagDescription  {
                            Name = "Amazon AWS",
                            Technologies = new string[] { "Amazon AWS", "AWS ", "AWS,", "AWS."}
                        },
                        new TagDescription  {
                            Name = "DevOpS",
                            Technologies = new string[] { "DevOpS", "devops"}
                        },
                        new TagDescription  {
                            Name = "GoogleCloudPlatform",
                            Technologies = new string[] {"Google Cloud"}
                        },
                        new TagDescription  {
                            Name = "Sitecore",
                            Technologies = new string[] {"Sitecore"}
                        },
                        new TagDescription  {
                            Name = "CI",
                            Technologies = new string[] {"CI ", "CI/", "CI,"}
                        },
                        new TagDescription  {
                            Name = "CD",
                            Technologies = new string[] {"CD ", "CD,"}
                        },
                        new TagDescription  {
                            Name = "IoC",
                            Technologies = new string[] {"IoC ", "IoC,", "IoC."}
                        },
                        new TagDescription  {
                            Name = "Orleans",
                            Technologies = new string[] {"Orleans"}
                        },
                        new TagDescription  {
                            Name = "Jenkins",
                            Technologies = new string[] {"Jenkins"}
                        },
                        new TagDescription  {
                            Name = "Gitlab",
                            Technologies = new string[] {"Gitlab"}
                        },
                        new TagDescription  {
                            Name = "ELK-Stack",
                            Technologies = new string[] {"ELK-Stack"}
                        },
                        new TagDescription  {
                            Name = "JIRA",
                            Technologies = new string[] {"JIRA"}
                        },
                        new TagDescription  {
                            Name = "Rider",
                            Technologies = new string[] {"Rider"}
                        }
                    }
                },

                new TagGroup {
                    Name = "BE",
                    TagDescriptions = new TagDescription[] {

                        new TagDescription  {
                            Name = "ASP.NET MVC",
                            Technologies = new string[] { "ASP .NET MVC", "ASP.NET MVC", "MVC", "ASP.NET"}
                        },
                        new TagDescription  {
                            Name = ".Net Framework",
                            Technologies = new string[] { ".Net Framework" }
                        },
                        new TagDescription  {
                            Name = ".Net Core",
                            Technologies = new string[] { ".Net Core" }
                        },
                        new TagDescription  {
                            Name = "..NET 6",
                            Technologies = new string[] { "NET 6", "NET6" }
                        },
                        new TagDescription  {
                            Name = "..NET 5",
                            Technologies = new string[] { "NET 5", "NET5" }
                        },
                        new TagDescription  {
                            Name = "ASP.NET Web API",
                            Technologies = new string[] { 
                                            "ASP.NET Web API",
                                            "Web API",
                                            "Web API",
                                            "WEB.API",
                                            "WebAPI"
                            }
                        },
                        new TagDescription  {
                            Name = "WPF",
                            Technologies = new string[] { "WPF" }
                        },
                        new TagDescription  {
                            Name = "WCF",
                            Technologies = new string[] { "WCF" }
                        },
                        new TagDescription  {
                            Name = "XML/XSL",
                            Technologies = new string[] { "XML/XSL",
                                                            "XML",
                                                            "XSL"
                            }
                        },
                        new TagDescription  {
                            Name = "N-Hibernate",
                            Technologies = new string[] { "N-Hibernate",
                                                        "NHibernate",
                                                        "Hibernate"
                            }
                        },
                        new TagDescription  {
                            Name = "Entity Framework",
                            Technologies = new string[] { "Entity Framework",
                                                            "EntityFramework" }
                        },
                        new TagDescription  {
                            Name = "ADO.NET",
                            Technologies = new string[] { "ADO.NET" }
                        },
                        new TagDescription  {
                            Name = "Rabbit MQ",
                            Technologies = new string[] { "Rabbit MQ",
                                                        "RabbitMQ" }
                        },
                        new TagDescription  {
                            Name = "Elastic Search",
                            Technologies = new string[] { "Elastic Search",
                                                        "ElasticSearch" }
                        },
                        new TagDescription  {
                            Name = "Message Queue",
                            Technologies = new string[] { "Message Queue",
                                                        "MessageQueue" }
                        },
                        new TagDescription  {
                            Name = "TPL",
                            Technologies = new string[] { "TPL" }
                        },
                        new TagDescription  {
                            Name = "Redis",
                            Technologies = new string[] { "Redis" }
                        },
                        new TagDescription  {
                            Name = "NServiceBus",
                            Technologies = new string[] { "NServiceBus",
                                                        "ServiceBus" },
                        },
                        new TagDescription  {
                            Name = "OData",
                            Technologies = new string[] { "OData" }
                        },
                        new TagDescription  {
                            Name = "Orleans",
                            Technologies = new string[] { "Orleans ", "Orleans,"}
                        },
                        new TagDescription  {
                            Name = "Docker",
                            Technologies = new string[] { "Docker", "Docker,"}
                        },
                        new TagDescription  {
                            Name = "Azure Functions",
                            Technologies = new string[] { "Azure Functions"}
                        },
                        new TagDescription  {
                            Name = "CosmosDb",
                            Technologies = new string[] { "CosmosDb"}
                        },
                        new TagDescription  {
                            Name = "Azure Tables,",
                            Technologies = new string[] { "Azure Tables"}
                        },
                        new TagDescription  {
                            Name = "Azure Blob Storage",
                            Technologies = new string[] { "Blob Storage"}
                        },
                        new TagDescription  {
                            Name = "Azure SQL",
                            Technologies = new string[] { "Azure SQL"}
                        }
                        
                    }
                },

                new TagGroup {
                    Name = "FE",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "JavaScript",
                            Technologies = new string[] { "JavaScript", "JScript", "Vanilla JS", "VanillaJS" }
                        },
                        new TagDescription  {
                            Name = "ECMAScript 6",
                            Technologies = new string[] { "ECMAScript 6", "ECMAScript6"}
                        },
                        new TagDescription  {
                            Name = "TypeScript",
                            Technologies = new string[] { "TypeScript", "TS/JS"}
                        },
                        new TagDescription  {
                            Name = "JQuery",
                            Technologies = new string[] { "JQuery"}
                        },
                        new TagDescription  {
                            Name = "CSS",
                            Technologies = new string[] { "CSS"}
                        },
                        new TagDescription  {
                            Name = "jQuery UI",
                            Technologies = new string[] { "jQuery UI", "jQueryUI"}
                        },
                        new TagDescription  {
                            Name = "Kendo UI",
                            Technologies = new string[] { "Kendo UI", "KendoUI"}
                        },
                        new TagDescription  {
                            Name = "AngularJS",
                            Technologies = new string[] { "Angular"}
                        },
                        new TagDescription  {
                            Name = "ReactJS",
                            Technologies = new string[] { "ReactJS", "React JS", "React" }
                        },
                        new TagDescription  {
                            Name = "VUE.js",
                            Technologies = new string[] { "VUE.js"}
                        },
                        new TagDescription  {
                            Name = "KnockoutJs",
                            Technologies = new string[] { "Knockout"}
                        },
                        new TagDescription  {
                            Name = "Bootstrap",
                            Technologies = new string[] { "Bootstrap"}
                        },
                        new TagDescription  {
                            Name = "JSON",
                            Technologies = new string[] { "JSON"}
                        },
                        new TagDescription  {
                            Name = "HTML5",
                            Technologies = new string[] { "HTML5"}
                        },
                        new TagDescription  {
                            Name = "AJAX",
                            Technologies = new string[] { "AJAX"}
                        },
                        new TagDescription  {
                            Name = "ReactiveUI",
                            Technologies = new string[] { "ReactiveUI"}
                        },
                        new TagDescription  {
                            Name = "Webpack",
                            Technologies = new string[] { "Webpack"}
                        },
                        new TagDescription  {
                            Name = "AMD CommonJS UMD",
                            Technologies = new string[] { "AMD CommonJS UMD", "AMD", "UMD"}
                        }
                    }
                },

                new TagGroup {
                    Name = "DataBase",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "MS SQL Server",
                            Technologies = new string[] { "SQLServer", "SQL Server", "MSSQL" }
                        },
                        new TagDescription  {
                            Name = "SQL, Transact SQL",
                            Technologies = new string[] {"SQL", "T-SQL" }
                        },
                        new TagDescription  {
                            Name = "RavenDB",
                            Technologies = new string[] { "RavenDB", "Raven DB", "Raven" }
                        },
                        new TagDescription  {
                            Name = "NoSQL",
                            Technologies = new string[] { "NoSQL", "No SQL" }
                        },
                        new TagDescription  {
                            Name = "Mongo DB",
                            Technologies = new string[] { "Mongo" }
                        },
                        new TagDescription  {
                            Name = "Cassandra",
                            Technologies = new string[] { "Cassandra" }
                        },
                        new TagDescription  {
                            Name = "PostgreSQL DB",
                            Technologies = new string[] { "Postgre" }
                        },
                        new TagDescription  {
                            Name = "DynamoDB",
                            Technologies = new string[] { "DynamoDB" }
                        },
                        new TagDescription  {
                            Name = "Oracle",
                            Technologies = new string[] { "Oracle" }
                        },
                        new TagDescription  {
                            Name = "MySql",
                            Technologies = new string[] { "MySql", "MySql ", "MySql,"}
                        }
                    }
                },

                new TagGroup {
                    Name = "TestArchitecture",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "Moq",
                            Technologies = new string[] { "Moq" }
                        },
                        new TagDescription  {
                            Name = "NUnit",
                            Technologies = new string[] { "NUnit" }
                        },
                        new TagDescription  {
                            Name = "NSpec",
                            Technologies = new string[] { "NSpec" }
                        },
                        new TagDescription  {
                            Name = "Jasmine",
                            Technologies = new string[] { "Jasmine" }
                        }
                    }
                },
                
                new TagGroup {
                    Name = "SoftwareDevelopmentMethodologies",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "Waterfall",
                            Technologies = new string[] { "Waterfall" }
                        },
                        new TagDescription  {
                            Name = "Agile",
                            Technologies = new string[] { "Agile" }
                        },
                        new TagDescription  {
                            Name = "Scrum",
                            Technologies = new string[] { "Scrum" }
                        },
                        new TagDescription  {
                            Name = "Kanban",
                            Technologies = new string[] { "Kanban" }
                        }
                    }
                }
                
                // Refactoring
                
                
            };
        }
    }


    public static class TagDescriptions
    {
        public static IEnumerable<TagDescription> GetAllTagDescriptions()
        {
            var allGroups = TagGroups.GetAllTagGroups().SelectMany(g => g.TagDescriptions);
            return allGroups;
        }
    }
}