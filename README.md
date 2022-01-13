# AZ-305 Discussion Topics

## Table of contents

- [01 - Design a governance solution](#01---design-a-governance-solution-learn-module)
- [02 - Design a compute solution](#02---design-a-compute-solution-learn-module)
- [03 - Design a non-relational data storage solution](#03---design-a-non-relational-data-storage-solution-learn-module)
- [04 - Design a data storage solution for relational data](#04---design-a-data-storage-solution-for-relational-data-learn-module)
- [05 - Design a data integration solution](#05---design-a-data-integration-solution-learn-module)
- [06 - Design an application architecture solution](#06---design-an-application-architecture-solution-learn-module)
- [07 - Design Authentication and Authorization Solutions](#07---design-authentication-and-authorization-solutions-learn-module)
- [08 - Design a solution to log and monitor Azure resources](#08---design-a-solution-to-log-and-monitor-azure-resources-learn-module)
- [09 - Design a network infrastructure solution](#09---design-a-network-infrastructure-solution-learn-module)
- [10 - Design a business continuity solution](#10---design-a-business-continuity-solution-learn-module)

# 01 - Design a governance solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-governance/2-design-for-governance))

## Governance ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/2-design-for-governance))

![whiteboard](/whiteboards/01-governance.png)

1. What is governance and why is it important? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/govern/methodology)
2. How can you organize your resources? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/govern/guides/standard/)
3. Where should I apply permissions for people to manage resources? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/roles)

## Management Groups ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/3-design-for-management-groups))

![whiteboard](/whiteboards/01-management-groups.png)

4. What are management groups and why should you consider implementing them? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups)
5. How many levels can management groups support? [[doc]](https://docs.microsoft.com/en-us/azure/governance/management-groups/overview)
6. Should you go for a deeply nested hierarchy, or for a reasonably flat one? Why? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups)
7. Why should you consider a top-level management group? [[doc]](https://docs.microsoft.com/en-us/learn/modules/design-governance/3-design-for-management-groups)
8. How would you organize your management groups? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups#management-groups-in-the-azure-landing-zone-accelerator)
9. How do you protect your management groups so that not everyone can create/update them? [[doc]](https://docs.microsoft.com/en-us/azure/governance/management-groups/overview#management-group-access)

## Subscriptions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/4-design-for-subscriptions))

![whiteboard](/whiteboards/01-subscriptions.png)

10. What is an Azure Subscription? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-subscriptions)
11. How many subscriptions do you need across your organization? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/scale-subscriptions)
12. Who is responsible for paying the subscription?
13. Which offer do I choose for my subscription? [[doc]](https://azure.microsoft.com/en-us/support/legal/offer-details/)
14. Are there any scale limits to my subscriptions? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/azure-subscription-service-limits)
15. I need to deploy 30,000 VMs. How many subscriptions do I need?
16. Should my organization go for a centralized vs decentralized approach? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/manage/centralize-operations)
17. We want to enforce common policies and role assignments across many subscriptions. What should we do? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/decision-guides/policy-enforcement/)
18. My developers want to setup sandboxes so they can experiment, but we want to isolate them from the production environment. What should we consider? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups)

## Resource groups ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/5-design-for-resource-groups))

![whiteboard](/whiteboards/01-resource-groups.png)

19. What is a resource group? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/fundamental-concepts)
20. How should I group resources? (by type, location, workload, billing, department, lifecycle, ...) [[doc]](https://docs.microsoft.com/en-us/learn/modules/control-and-organize-with-azure-resource-manager/2-principles-of-resource-groups)
21. I have a resource group in WESTEU. Can I deploy resources in NORTHEU? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/manage-resource-groups-portal#what-is-a-resource-group)
22. Can I move resources between resource groups? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/move-resource-group-and-subscription) [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/move-support-resources)
23. Can I nest resource groups?
24. Can I deploy a resource in multiple resource groups?
25. Should I apply permissions and at what level?
26. I don't want anyone to delete my central Azure Firewall. What can I do?

## Resource tags? ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/6-design-for-resource-tags))

![whiteboard](/whiteboards/01-resource-tags.png)

27. What's the purpose of resource tags? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-resources?tabs=json)
28. How many tags can I apply to a resource? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-resources?tabs=json)
29. If I apply a tag at the level of a resource group, will it inherit down to the individual resource? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-policies)
30. Can you come up with some examples where you could leverage tags on resources? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/decision-guides/resource-tagging/?toc=/azure/azure-resource-manager/management/toc.json)
31. Will you implement a chargeback or show back accounting system?
32. Does tagging need to represent details such regulatory compliance requirements for a resource?
33. What can I do to enforce tagging [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-policies#policy-definitions)
34. Are there resources which do not support tagging? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-support)
35. What tags will be required for all resources based on centralized IT policy? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/resource-tagging)

## Azure Policy ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/7-design-for-azure-policy))

![whiteboard](/whiteboards/01-policy.png)

36. What is an Azure Policy? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview)
37. At what level should you apply an Azure Policy? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview#assignments)
38. I have multiple Azure Policies to enforce. Any recommendations? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/initiative-definition-structure) [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/samples/built-in-initiatives)
39. When are Azure Policies evaluated? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview#understand-evaluation-outcomes) [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/evaluate-impact) [[doc]](https://docs.microsoft.com/en-us/learn/modules/design-governance/7-design-for-azure-policy)
40. What should happen when the resource is not compliant against the policy? What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/effects)
41. Can I automatically remediate the resource to become compliant? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/event-overview) [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/tutorials/route-state-change-events) [[doc]](https://docs.microsoft.com/en-us/azure/logic-apps/policy-reference)

## RBAC (Role Based Access Control) ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/8-design-for-role-based-access-control))

![whiteboard](/whiteboards/01-rbac.png)

42. Who should I give access, and at what level? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/roles)
43. Should I assign roles to users or groups? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/best-practices)
44. Should everyone be an owner/contributor? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/deny-assignments)
45. When should you create a custom role? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/custom-roles) [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/roles#use-custom-roles)
46. What happens if roles are overlapping? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/overview#how-azure-rbac-determines-if-a-user-has-access-to-a-resource)
47. How to allow some users to control the virtual machines in an environment but prevent them from modifying networking and other resources in the same resource group or Azure subscription?
48. Can you assign a role to a non-user? (aka service account?) [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-steps)
49. How does Azure Policy differ from RBAC? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview#azure-policy-and-azure-rbac)

## Azure Blueprints ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/9-design-for-azure-blueprints))

![whiteboard](/whiteboards/01-blueprints.png)

50. What is an Azure Blueprint and why would I consider this? [[doc]](https://docs.microsoft.com/en-us/azure/governance/blueprints/overview)
51. What elements are part of an Azure Blueprint?
52. How do we enforce compliance? [[doc]](https://docs.microsoft.com/en-us/azure/governance/blueprints/samples/)

# 02 - Design a compute solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/))

![whiteboard](/whiteboards/02-compute.png)

## Virtual Machines ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/3-design-for-azure-virtual-machine-solutions))

![whiteboard](/whiteboards/02-vm.png)

53. What could be reasons to choose for Virtual Machines instead of PaaS services?
54. Who is responsible for your VM? Microsoft or the customer?
55. Can you run any VM in any region? What about pricing?
56. I need to run a database. Which VM size should I use?
57. Managed disks versus unmanaged disks?
58. I need to set up a Linux server with an Apache web server, a MySQL Database and PHP installed already on it. What are my options?
59. Why should I consider creating my own disk images?

## Virtual Machine Scale Sets ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/3-design-for-azure-virtual-machine-solutions))

![whiteboard](/whiteboards/02-vmss.png)

60. What are Virtual Machine Scale Sets?
61. My VM Scale Set needs high availability. What are my options?
62. I need to deploy my application to VM Scale Set. What are my options?

## Azure Batch ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/4-design-for-azure-batch-solutions))

![whiteboard](/whiteboards/02-batch.png)

63. What is Azure Batch?
64. What are some use cases to consider Azure Batch?
65. What is the difference between a batch Pool, Node and Job?

## Azure App Service ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/5-design-for-azure-app-services-solutions))

![whiteboard](/whiteboards/02-app-service.png)

66. What is it that I pay for with an Azure App Service?
67. Why would I consider deployment slots?
68. My developers have difficulties implementing authentication and authorization. Can App Service provide this capability?
69. I want to run a web app implemented in Go (Golang) in Azure App Service but find out that this language is not supported. What are my options?
70. What are WebJobs? Why would I use these or should I use something different?

## Container Instances ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/6-design-for-azure-container-instances-solutions))

![whiteboard](/whiteboards/02-container-instances.png)

71. What are Azure Container Instances and why should I use it?
72. When/Why should I NOT use it?
73. What are multi-container groups?
74. Why should I consider containers instead of Virtual Machines? (isolation, operating system, deployment, persistent storage, fault tolerance)
75. What is a Virtual Kubelet?

## Azure Kubernetes ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/7-design-for-azure-kubernetes-solutions))

![whiteboard](/whiteboards/02-kubernetes.png)

76. What is Azure Kubernetes?
77. Who needs to manage the Kubernetes cluster?
78. What do you pay for?
79. Can you deploy multiple Virtual Machine sizes/types?
80. What methods exist to scale your application running on AKS?
81. How can I isolate certain workloads inside my AKS cluster?
82. What technology can I use when my application requires persistent storage?
83. What are 2 ways of synchronizing storage across clusters?
84. Can my application running on AKS connect to on-premise resources?
85. I'm concerned about vulnerabilities and outdated base images. What can I do about this?
86. Can I deploy multiple AKS clusters across non-paired regions?

## Azure Functions / Logic Apps ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/8-design-for-azure-functions-solutions))

![whiteboard](/whiteboards/02-functions.png)

87. Why would I consider Azure Functions? Do you have some scenarios?
88. What do I pay for when using Serverless Functions?
89. When should you NOT use Logic Apps?
90. What are durable functions and why should I consider these?
91. What are the different hosting plans available for Azure Functions and why should I choose for one over the other?
92. Why would I consider to use a Premium plan for Azure Functions?

## Logic Apps ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/9-design-for-logic-app-solutions))

![whiteboard](/whiteboards/02-logic-apps.png)

93. Why would I consider Logic Apps? Do you have some scenarios?
94. My application requires some complex business rules. Should I use Logic Apps?
95. What do I pay for when using Logic Apps?
96. Can I run a Logic App on a separate plan? Why would I do this?
97. What are some differences between a Logic App and Durable Functions?

# 03 - Design a non-relational data storage solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/))

## Data Storage ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/2-design-for-data-storage))

![whiteboard](/whiteboards/03-data-storage.png)

98. What is the difference between Structured/Unstructured/Semi-structured?
99. What are your options for storing unstructured data in Azure? Why would you choose one over the other?

## Azure Storage ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/3-design-for-azure-storage-accounts))

![whiteboard](/whiteboards/03-azure-storage.png)

100. When should you NOT choose a Standard General Purpose V2 storage account?
101. How many storage accounts do you actually need? What should you consider?
102. What does the SLA of 99.9% or 99.99% mean in relation to an Azure Storage account?
103. Does replication between data centers and regions happen synchronous?
104. Can I read from a secondary region?
105. Under what circumstances can you have loss of data, even when replication has been setup?
106. Will Microsoft fail over or is the customer who initiates the fail over to another region?
107. Why would I consider the cool storage and archive storage tiers?
108. How many hours can it take to rehydrate archived blobs?
109. Why would I use immutable storage for Azure Storage?
110. What is the difference between time-based retention policies and legal hold policies?
111. Which data sets and policies would be most helpful in your organization?

## Azure Files ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/6-design-for-azure-files))

![whiteboard](/whiteboards/03-azure-files.png)

112. When would you use Azure Files instead of Azure Blob storage?
113. Which protocols are supported with Azure Files?
114. What is file sync and why do you need it?
115. Which file storage tiers exists and which one would you choose in the following scenarios
116. Why would I consider Azure NetApp files?

## Azure Disks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/7-design-for-azure-disk-solutions))

![whiteboard](/whiteboards/03-azure-disks.png)

117. Azure offers Ultra-disk, Premium SSD, Standard SSD and Standard HDD disk types. What could be a valid scenario to choose one over the other?
118. Why would I consider to change disk caching from None to ReadOnly or Read/Write? How should I configure these when implementing a SQL Server Database?
119. Encryption types for Managed Azure Disks includes Azure Disk Encryption (ADE), Server-Side Encryption (SSE) and encryption at host. What's the difference and should you combine these?
120. What is the difference between an image and a snapshot?
121. Can you share multiple disks across VM's?
122. How can you improve performance by implementing multiple disks?

## Storage security ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/8-design-for-storage-security))

![whiteboard](/whiteboards/03-storage-security.png)

123. Why should I never hand out the Azure Storage Account Key?
124. What is a Shared Access Signature and at which level can I create it?
125. Should I protect my storage account at the network level? What are my options?
126. Can I bring my own encryption key? How granular can I implement this?

# 04 - Design a data storage solution for relational data ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data))

## Azure SQL Database ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/))

![whiteboard](/whiteboards/04-azure-sql.png)

127. Azure SQL Database can be hosted in many ways. What could be my decision criteria?
128. What are elastic pools?
129. How can Elastic pools help you achieve vertical scaling?
130. What is the difference between DTU and the vCore model?
131. When should I consider the serverless compute tier for Azure SQL Database?
132. Why would I choose for the Business Critical tier instead of the General Purpose Tier?
133. Why would I consider the Hyperscale tier instead of a Dedicated pool in Azure Synapse Analytics?
134. There are 2 types of horizontal scaling - sharding and read-scale-out.
135. Azure SQL Database offers the following capabilities for recovering from an outage. Why would I choose for one over the other?
136. What encryption mechanisms should I consider when data is at rest, in motion and in process
137. Azure SQL Database supports SQL authencation and Azure Active Directory authentication. Why should I consider AAD authentication?

## Azure SQL Edge ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/8-design-for-azure-sql-edge))

138. When would you consider to use Azure SQL Edge?
139. What technology do you need to deploy Azure SQL Edge on?

## Azure Cosmos DB ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/9-design-for-azure-cosmos))

140. When would you consider to use Azure Cosmos DB?
141. Table data can be stored as part of Azure Table Storage or inside Azure Cosmos DB. Why would you chose one over the other?
142. How can you manage performance of an Azure Cosmos DB?

# 05 - Design a data integration solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/))

## Azure Data Factory ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/2-solution-azure-data-factory))

143. Why would you consider Azure Data Factory over SSIS (SQL Server Integration Services)?
144. What do you pay for when using Azure Data Factory?
145. What component of Azure Data Factory would you consider to perform data transformations? What alternatives are there?
146. What is a Self-Hosted Integration Runtime and why do you need it?

## Azure Data Lake ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/3-solution-azure-data-lake))

147. Azure Data Lake is built on top of Azure Blob Storage. What does it add?
148. Why would I choose for a Data Lake, instead of regular Blob Storage? What could be my decision criteria?
149. Why would I choose for Blob Storage, instead of Data Lake?
150. Why is it important to support RBAC down to the individual file level?
151. I need to organize my Data Lake. What are some common approaches?

## Azure Databricks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/4-solution-azure-data-brick))

152. What is Azure Databricks and what is Apache Spark?
153. Which role would be using Azure Databricks?
154. When would you choose to implement Azure Databricks?

## Azure Synapse Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/5-solution-azure-synapse-analytics))

155. What is the difference between a serverless pool and a dedicated pool?
156. What do I pay for with Synapse Analytics?
157. Azure Synapse Analytics contains a component to set up pipelines and data flows, which is also part of Azure Data Factory. Why would I use this instead of ADF?
158. Azure Synapse Analytics allows you to setup Spark Pools to process your data. Why would I consider this instead of Azure Databricks?
159. What is Azure Synapse Link for Cosmos DB and what is the use case it tries to solve?

## Strategy for hot/warm/cold data path ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/6-design-strategy-for-hot-warm-cold-data-path))

160. When to use Hot/Warm/Cold data path?

## Azure Stream Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/7-design-azure-stream-analytics-solution-for-data-analysis))

161. When would you consider to use Azure Stream Analytics? (use cases)
162. What is a streaming unit (SU)?
163. What are the main components to setup in Azure Stream Analytics?

# 06 - Design an application architecture solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/))

## Message and event scenarios ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/2-describe-message-event-scenarios))

164. What is the difference between an event and a message and when would you choose for one over the other?
165. Suppose you have a distributed application with a web service that authenticates users. When a user logs on, the web service notifies all the client applications so they can display that user's status as "Online". Is the login notification an example of a message or an event?
166. Let’s suppose a user uploads a new song by using your mobile music-sharing app. The mobile app must send that song to a web API that runs in Azure. The mobile app expects that the web API stores the new song in the database and makes it available to other users. Is this an example of a message or an event?

## Messaging solutions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/3-design-messaging-solution))

167. What are Azure Storage Queues and Azure Service Bus Queues?
168. What is an Azure Service Bus Topic?
169. Which messaging service should you choose? why choose for Azure Service Bus over Azure Storage Queues?
170. What API do you use to interact with Azure Storage Queue?
171. What can you do if the payload of a message is larger than 64 KB in size?

## Event solutions (Event Hub and Event Grid) ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/4-design-event-hub-messaging-solution))

172. What is Event Hub and how does it compare to Azure Event Grid?
173. What is the main consideration for the ‘pull’ model provided by Event Hubs?
174. How does Event Hub handle throughput?
175. How much will you pay for storing 80GB of data per day in Event Hub?
176. How does Event Hub relate to Kafka?
177. What does Event Hub capture provide to you? Why is this important?
178. What can you do if the payload of an event is larger than 256 KB?
179. What is IoT Hub and what capabilities will it add over Event Hub?

## Caching ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/6-design-caching-solution))

180. When would you consider to use an Azure Cache for Redis?

## API Management ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/7-design-api-integration))

181. Why would you introduce an API management solution as implemented by APIM? What are the benefits/use case cases?

## Application lifecycle ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/8-design-automated-app-deployment-solution))

182. What Infrastructure as Code (IaC) technique do you use to automate the provisioning of infrastructure?
183. Why would you use ARM templates versus Bicep?
184. Why would you use Azure DevOps instead of GitHub?
185. Why would you use Terraform instead of ARM/Bicep?
186. What does Azure App Configuration offer to you?

## Application configuration ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/9-configuration-management-solution))

# 07 - Design Authentication and Authorization Solutions ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/))

## Identity and access management ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/2-design-for-identity-access-management))

187. What is the difference between AAD, AAD B2B and AAD B2C
188. What is AADDS?

## Azure Active Directory ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/3-design-for-azure-active-directory))

189. What is Azure AD Connect and what is Azure AD Connect Cloud Sync? What could be a use case to use AAD Connect cloud sync?
190. Is Azure AD Connect one-direction-only or does it support bi-directional replication?
191. Does it make sense to deploy multiple AAD Tenants? Or should you stick with a single tenant?
192. Why should you not synchronize accounts to Azure AD that have high privileges?
193. Is Password Hash Synchronization safe to use?
194. What is that SSO helps you to do?
195. Should you centralize or de-centralize your identity management. Can you do both?

## Azure Active Directory B2B ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/4-design-business-business))

196. Why would you consider Azure AD B2B?
197. When implementing Azure AD B2B, does your partner need to have AAD as well? What identity providers are supported?
198. Can you enforce MFA for guest accounts, even when they do not have this configured?
199. What is an Access Panel?
200. Who can invite guests? Should you centralize / de-centralize?
201. What is a self-service sign-up flow? Can you customize this?

## Azure Active Directory B2C ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/5-design-business-customer))

202. Why would you consider Azure AD B2C?
203. When implementing Azure AD B2B, does your client need to have AAD as well? What identity providers are supported?
204. What is user flow? And can you customize the look and feel of the user interface?
205. Where should I store custom user attributes?

## Conditional access ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/6-design-for-conditional-access))

206. What scenarios can you think of where conditional access would be beneficial?
207. Why does conditional access provide more granular control over the MFA policies?
208. You are not sure about the impact of changing a conditional access policy. What should you use?
209. Which license do you need to use conditional access?
210. You want to prevent people from using older legacy protocols like POPHowever, your CEO is still using an old laptop/software. What are your options?

## Identity protection ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/7-design-for-identity-protection))

211. What's the difference between sign-in risk and user risk?
212. What are some common examples of sign-in risk and user risk?
213. What should you do to enable break-the-glass/emergency access account?

## Access reviews ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/8-design-for-access-reviews))

214. What is an access review and why should you use it?
215. What problem is it trying to solve?
216. What license do you require?
217. Who can conduct a review during an access review?

## Service principals for applications ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/9-design-service-principles))

218. What is a managed identity and what is it trying to solve?
219. What is the difference between a user assigned identity and a system managed identity?
220. What is the Azure Instance Metadata Service, and why is it important in the context of managed identity?
221. What is a service principal?
222. Can you explain the relationship between application objects and service principals?
223. Microsoft identity platform supports two types of permissions - delegated permissions and application permissions. What is used when?

## Azure key vault ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/10-design-for-azure-key-vault))

224. Why use Azure Key Vault?
225. How many Azure Key Vaults do you require for your applications?
226. What is the difference between a key and a secret in Azure Key Vault?
227. What is the difference between a key and a certificate in Azure Key vault?
228. Azure Key Vault has two service tiers - Standard and Premium. Why would you choose one over the other?
229. How can you authenticate against Azure Key Vault? (2 supported modes)

# 08 - Design a solution to log and monitor Azure resources ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/))

## Azure Monitor ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/2-design-for-azure-monitor-data-sources))

230. Azure Monitor collects data automatically from a range of components. Can you share some examples/use cases?
231. Example - you have experienced recently an Azure Storage Account Key leakage. How can you prevent this in future?

## Log Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/3-design-for-log-analytics))

232. How many Log Analytics resources do you need?
233. Would you go for a centralized or decentralized approach? Hybrid?
234. What do you pay for?
235. What is the retention time for log data that has been ingested. Can you change this?
236. How can you integrate logging data from Virtual Machines?
237. What can you do to create a dashboard targeted towards business users, showing them some relevant metrics?
238. You want to prevent users from accessing certain data in you Log Analytics workspace. Is this possible and how?
239. Does Log Analytics have some rate limits applicable?
240. How do you enforce capturing logging from your Azure resources into Log Analytics?

## Azure workbooks and Azure Insights ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/4-design-for-azure-workbooks-insights))

241. What are Azure Workbooks?
242. Why would you consider to implement an Azure Workbook?
243. What is Azure Application Insights and what does it offer on top of Log Analytics?
244. What can you use the monitor your Azure Kubernetes environment?

## Azure Data Explorer ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/5-design-for-azure-data-explorer))

245. What is Azure Data Explorer?
246. What do you pay for?

# 09 - Design a network infrastructure solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/))

## Recommend a network architecture solution based on workload requirements ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/2-recommend-network-architecture-solution-based-workload-requirements))

247. Why would you want to create multiple virtual networks, or create multiple subnets in your VNET? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/hybrid-networking/network-level-segmentation) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-vnet-plan-design-arm)
248. Why does it matter to apply a naming convention when creating virtual networks? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/resource-naming#example-names-networking)
249. Can you deploy resources across multiple regions in the same virtual network?
250. How large should your virtual network's address space be?
251. What is the difference between a network virtual appliance (NVA) like a Firewall and a NSG Network Security Group?
252. What is a hub and spoke topology and why would you consider it? What are the benefits/disadvantages?

## Design for on-premises connectivity to Azure virtual networks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/3-design-for-premises-connectivity-to-azure-virtual-networks))

253. Which Azure VPN Gateway SKU should you implement and why?
254. What is the SLA offered by VPN Gateway and what is/is not included? How can you increase the SLA?
255. Is traffic encrypted over the VPN Gateway?
256. What can you do to troubleshoot your VPN connection?
257. Why would you consider an Express Route?
258. Can you use an Express route and combine it with a VPN Gateway? Why would you do this?
259. What advantage brings Azure Virtual WAN to the table?

## Design for Azure network connectivity services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/4-design-for-azure-network-connectivity-services))

260. When setting up peering between 2 virtual networks, is traffic encrypted?
261. What do you pay for when using VNET Peering?
262. Why would you consider implementing Virtual Network NAT (Network Address Translation)?
263. Why would you consider overriding Azure's default routing? How do you accomplish this?

## Design for application delivery services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/5-design-for-application-delivery-services))

264. Why would you consider to use an Azure CDN Content Delivery Network. What problem does it solve?
265. What possible sources should you consider for Azure CDN?
266. What would you pay for and how does it compare to other services like Azure App Service?
267. What are the differences between Load Balancer, Traffic Manager, Application Gateway and Front Door?

## Design for application protection services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/6-design-for-application-protection-services)))

268. Why would you want to go for Azure DDoS protection Standard instead of the default one?
269. What would you pay for when using this service?
270. What problem is it that Azure Private Link is trying to solve?
271. Should you consider Azure Firewall or go for any other 3rd party firewall technology?
272. What are the advantages and disadvantages of setting up Service Endpoints?
273. What's the difference between Network Security Groups and Application Security Groups
274. What problem is it that Azure Bastion solves?
275. How can you implement Just in Time Access?

# 10 - Design a business continuity solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/))

## Backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/2-design-recovery))

276. What is the difference between RTO and RPO? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/manage/considerations/protect) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/business-continuity-high-availability-disaster-recover-hadr-overview) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/framework/resiliency/business-metrics)
277. What are SLA's and why does it matter? Who provides the SLA? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/manage/considerations/impact) [[doc]](https://azure.microsoft.com/en-us/support/legal/sla/)
278. How would you calculate the SLA? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/framework/resiliency/business-metrics#understand-service-level-agreements)
279. What is MTBF and MTTR and what would be appropriate values?
280. How do you know that a service/application does (not) reach it's SLA? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/framework/devops/checklist) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/monitoring/enterprise-monitoring) [[doc]](https://docs.microsoft.com/en-us/azure/azure-monitor/app/availability-overview)
281. Why do you need both disaster recovery and backup? [[doc]](https://docs.microsoft.com/en-us/learn/modules/describe-high-availability-disaster-recovery-strategies/3-explore-high-availability-disaster-recovery-options)
282. Why would you test your disaster recovery?

## Azure Backup ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/3-design-for-azure-backup))

283. What can you backup with Azure Backup? [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-support-matrix)
284. What do you pay for? [[doc]](https://azure.microsoft.com/en-us/pricing/details/backup/)
285. How much data can you store and for how long? [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-azure-vm-backup-faq) [[doc]](https://docs.microsoft.com/en-us/azure/backup/archive-tier-support)
286. What does it mean to have application consistent backups?
287. Can you backup SQL databases with it? [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-azure-sql-database)
288. Does it store backups also across regions? Only the region pair or other regions? [[doc]](https://docs.microsoft.com/en-us/azure/backup/guidance-best-practices)
289. Why is it important to protect your Azure Backup? How can you accomplish this? [[doc]](https://docs.microsoft.com/en-us/azure/backup/guidance-best-practices#security-considerations)

## Azure blob backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/4-design-for-azure-blob-backup-recovery))

290. What are the features you can use with Azure Blob storage to be able to recover data without Azure Backup? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/data-protection-overview)
291. Can you perform a Point-in-time restore on Azure Blob storage? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/point-in-time-restore-overview)
292. Can you use Azure Backup to backup Azure Blob storage? Why would you use/not use this?
293. Can you recover a deleted Azure Storage account? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-account-recover)
294. How many years can you configure immutable storage? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/immutable-storage-overview) [[doc]](https://www.rijksmuseum.nl/nl/collectie/SK-A-1699)

## Azure Files backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/5-design-for-azure-files-backup-recovery))

295. What are Azure Files snapshots?
296. How would you automate file share backups?
297. Why should you configure alerting and reporting provided by Azure Backup? [[doc]](https://docs.microsoft.com/en-us/azure/backup/monitoring-and-alerts-overview) [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-afs)
298. Why would you want to perform an on-demand backup of a file share if it is also scheduled? [[doc]](https://docs.microsoft.com/en-us/azure/backup/manage-recovery-points)

## Azure virtual machine backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/6-design-for-azure-virtual-machine-backup-recovery))

299. What is the difference between snapshot tier and vault tier?

## Azure SQL backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/7-design-for-azure-sql-backup-recovery))

300. How does Azure SQL perform backups and what's the interval, RPO and RTO? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/automated-backups-overview?tabs=single-database)
301. What happens in case a region goes down? Can I restore to another region and who is responsible for this? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/business-continuity-high-availability-disaster-recover-hadr-overview)

## Azure Site Recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/8-design-for-azure-site-recover))

302. Why would you choose Azure Site Recovery over another (3rd-party) solution?
303. Why would you combine Azure Site Recovery with Azure Backup?

