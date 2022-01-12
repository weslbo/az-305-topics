# AZ-305 Discussion Topics

## Table of contents

- [01 - Governance](#01---governance-learn-module)
- [02 - Compute](#02---compute-learn-module)
- [03 - Design a non-relational data storage solution](#03---design-a-non-relational-data-storage-solution-learn-module)
- [04 - Design a data storage solution for relational data](#04---design-a-data-storage-solution-for-relational-data-learn-module)
- [05 - Design a data integration solution](#05---design-a-data-integration-solution-learn-module)
- [06 - Design an application architecture solution](#06---design-an-application-architecture-solution-learn-module)
- [07 - Design Authentication and Authorization Solutions](#07---design-authentication-and-authorization-solutions-learn-module)
- [08 - Design a solution to log and monitor Azure resources](#08---design-a-solution-to-log-and-monitor-azure-resources-learn-module)
- [09 - Design a network infrastructure solution](#09---design-a-network-infrastructure-solution-learn-module)
- [10 - Design a business continuity solution](#10---design-a-business-continuity-solution-learn-module)

# 01 - Governance ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-governance/2-design-for-governance))

## Governance ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/2-design-for-governance))

1. What is governance and why is it important?
2. How can you organize your resources?
3. Where should I apply permissions for people to manage resources?

![whiteboard](/whiteboards/01-governance.png)

## Management Groups ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/3-design-for-management-groups))

4. What are management groups and why should you consider implementing them?
5. How many levels can management groups support?
6. Should you go for a deeply nested hierarchy, or for a reasonably flat one? Why?
7. Why should you consider a top-level management group?
8. How would you organize your management groups?
9. How do you protect your management groups so that not everyone can create/update them?

![whiteboard](/whiteboards/01-management-groups.png)

## Subscriptions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/4-design-for-subscriptions))

10. What is an Azure Subscription?
11. How many subscriptions do you need across your organization?
12. Who is responsible for paying the subscription?
13. Which offer do I choose for my subscription?
14. Are there any scale limits to my subscriptions?
15. I need to deploy 30,000 VMs. How many subscriptions do I need?
16. Should my organization go for a centralized vs decentralized approach?
17. We want to enforce common policies and role assignments across many subscriptions. What should we do?
18. My developers want to setup sandboxes so they can experiment, but we want to isolate them from the production environment. What should we consider?

![whiteboard](/whiteboards/01-subscriptions.png)

## Resource groups ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/5-design-for-resource-groups))

19. What is a resource group?
20. How should I group resources? (by type, location, workload, billing, department, lifecycle, ...)
21. I have a resource group in WESTEU. Can I deploy resources in NORTHEU?
22. Can I move resources between resource groups?
23. Can I nest resource groups?
24. Can I deploy a resource in multiple resource groups?
25. Should I apply permissions and at what level?
26. I don't want anyone to delete my central Azure Firewall. What can I do?

![whiteboard](/whiteboards/01-resource-groups.png)

## Resource tags? ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/6-design-for-resource-tags))

27. What's the purpose of resource tags?
28. How many tags can I apply to a resource?
29. If I apply a tag at the level of a resource group, will it inherit down to the individual resource?
30. Can you come up with some examples where you could leverage tags on resources?
31. Will you implement a chargeback or show back accounting system?
32. Does tagging need to represent details such regulatory compliance requirements for a resource?
33. What can I do to enforce tagging
34. Are there resources which do not support tagging?
35. What tags will be required for all resources based on centralized IT policy?

![whiteboard](/whiteboards/01-resource-tags.png)

## Azure Policy ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/7-design-for-azure-policy))

36. What is an Azure Policy?
37. At what level should you apply an Azure Policy?
38. I have multiple Azure Policies to enforce. Any recommendations?
39. When are Azure Policies evaluated?
40. What should happen when the resource is not compliant against the policy? What are my options?
41. Can I automatically remediate the resource to become compliant?

![whiteboard](/whiteboards/01-policy.png)

## RBAC (Role Based Access Control) ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/8-design-for-role-based-access-control))

42. Who should I give access, and at what level?
43. Should I assign roles to users or groups?
44. Should everyone be an owner/contributor?
45. When should you create a custom role?
46. What happens if roles are overlapping?
47. How to allow some users to control the virtual machines in an environment but prevent them from modifying networking and other resources in the same resource group or Azure subscription?
48. Can you assign a role to a non-user? (aka service account?)
49. How does Azure Policy differ from RBAC?

![whiteboard](/whiteboards/01-rbac.png)

## Azure Blueprints ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/9-design-for-azure-blueprints))

50. What is an Azure Blueprint and why would I consider this?
51. What elements are part of an Azure Blueprint?
52. How do we enforce compliance?

![whiteboard](/whiteboards/01-blueprints.png)

# 02 - Compute ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/))

## Virtual Machines ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/3-design-for-azure-virtual-machine-solutions))

53. What could be reasons to choose for Virtual Machines instead of PaaS services?
54. Who is responsible for your VM? Microsoft or the customer?
55. Can you run any VM in any region? What about pricing?
56. I need to run a database. Which VM size should I use?
57. Managed disks versus unmanaged disks?
58. I need to set up a Linux server with an Apache web server, a MySQL Database and PHP installed already on it. What are my options?
59. Why should I consider creating my own disk images?

## Virtual Machine Scale Sets ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/3-design-for-azure-virtual-machine-solutions))

60. What are Virtual Machine Scale Sets?
61. My VM Scale Set needs high availability. What are my options?
62. I need to deploy my application to VM Scale Set. What are my options?

## Azure Batch ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/4-design-for-azure-batch-solutions))

63. What is Azure Batch?
64. What are some use cases to consider Azure Batch?
65. What is the difference between a batch Pool, Node and Job?

## Azure App Service ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/5-design-for-azure-app-services-solutions))

66. What is it that I pay for with an Azure App Service?
67. Why would I consider deployment slots?
68. My developers have difficulties implementing authentication and authorization. Can App Service provide this capability?
69. I want to run a web app implemented in Go (Golang) in Azure App Service but find out that this language is not supported. What are my options?
70. What are WebJobs? Why would I use these or should I use something different?

## Container Instances ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/6-design-for-azure-container-instances-solutions))

71. What are Azure Container Instances and why should I use it?
72. When/Why should I NOT use it?
73. What are multi-container groups?
74. Why should I consider containers instead of Virtual Machines? (isolation, operating system, deployment, persistent storage, fault tolerance)
75. What is a Virtual Kubelet?

## Azure Kubernetes ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/7-design-for-azure-kubernetes-solutions))

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

87. Why would I consider Azure Functions / Logic Apps? Do you have some scenarios?
88. My application requires some complex business rules. Should I use Logic Apps?
89. What do I pay for when using Serverless Functions?
90. What do I pay for when using Logic Apps?
91. When should you NOT use Logic Apps?
92. What are durable functions and why should I consider these?
93. What are the different hosting plans available for Azure Functions and why should I choose for one over the other?
94. Can I run a Logic App on a separate plan? Why would I do this?
95. What are some differences between a Logic App and Durable Functions?
96. Why would I consider to use a Premium plan for Azure Functions?

# 03 - Design a non-relational data storage solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/))

## Data Storage ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/2-design-for-data-storage))

97. What is the difference between Structured/Unstructured/Semi-structured?
98. What are your options for storing unstructured data in Azure? Why would you choose one over the other?

## Azure Storage ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/3-design-for-azure-storage-accounts))

99. When should you NOT choose a Standard General Purpose V2 storage account?
100. How many storage accounts do you actually need? What should you consider?
101. What does the SLA of 99.9% or 99.99% mean in relation to an Azure Storage account?
102. Does replication between data centers and regions happen synchronous?
103. Can I read from a secondary region?
104. Under what circumstances can you have loss of data, even when replication has been setup?
105. Will Microsoft fail over or is the customer who initiates the fail over to another region?
106. Why would I consider the cool storage and archive storage tiers?
107. How many hours can it take to rehydrate archived blobs?
108. Why would I use immutable storage for Azure Storage?
109. What is the difference between time-based retention policies and legal hold policies?
110. Which data sets and policies would be most helpful in your organization?

## Azure Files ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/6-design-for-azure-files))

111. When would you use Azure Files instead of Azure Blob storage?
112. Which protocols are supported with Azure Files?
113. What is file sync and why do you need it?
114. Which file storage tiers exists and which one would you choose in the following scenarios
115. Why would I consider Azure NetApp files?

## Azure Disks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/7-design-for-azure-disk-solutions))

116. Azure offers Ultra-disk, Premium SSD, Standard SSD and Standard HDD disk types. What could be a valid scenario to choose one over the other?
117. Why would I consider to change disk caching from None to ReadOnly or Read/Write? How should I configure these when implementing a SQL Server Database?
118. Encryption types for Managed Azure Disks includes Azure Disk Encryption (ADE), Server-Side Encryption (SSE) and encryption at host. What's the difference and should you combine these?
119. What is the difference between an image and a snapshot?
120. Can you share multiple disks across VM's?
121. How can you improve performance by implementing multiple disks?

## Storage security ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/8-design-for-storage-security))

122. Why should I never hand out the Azure Storage Account Key?
123. What is a Shared Access Signature and at which level can I create it?
124. Should I protect my storage account at the network level? What are my options?
125. Can I bring my own encryption key? How granular can I implement this?

# 04 - Design a data storage solution for relational data ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data))

## Azure SQL Database ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/))

126. Azure SQL Database can be hosted in many ways. What could be my decision criteria?
127. What are elastic pools?
128. How can Elastic pools help you achieve vertical scaling?
129. What is the difference between DTU and the vCore model?
130. When should I consider the serverless compute tier for Azure SQL Database?
131. Why would I choose for the Business Critical tier instead of the General Purpose Tier?
132. Why would I consider the Hyperscale tier instead of a Dedicated pool in Azure Synapse Analytics?
133. There are 2 types of horizontal scaling - sharding and read-scale-out.
134. Azure SQL Database offers the following capabilities for recovering from an outage. Why would I choose for one over the other?
135. What encryption mechanisms should I consider when data is at rest, in motion and in process
136. Azure SQL Database supports SQL authencation and Azure Active Directory authentication. Why should I consider AAD authentication?

## Azure SQL Edge ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/8-design-for-azure-sql-edge))

137. When would you consider to use Azure SQL Edge?
138. What technology do you need to deploy Azure SQL Edge on?

## Azure Cosmos DB ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/9-design-for-azure-cosmos))

139. When would you consider to use Azure Cosmos DB?
140. Table data can be stored as part of Azure Table Storage or inside Azure Cosmos DB. Why would you chose one over the other?
141. How can you manage performance of an Azure Cosmos DB?

# 05 - Design a data integration solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/))

## Azure Data Factory ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/2-solution-azure-data-factory))

142. Why would you consider Azure Data Factory over SSIS (SQL Server Integration Services)?
143. What do you pay for when using Azure Data Factory?
144. What component of Azure Data Factory would you consider to perform data transformations? What alternatives are there?
145. What is a Self-Hosted Integration Runtime and why do you need it?

## Azure Data Lake ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/3-solution-azure-data-lake))

146. Azure Data Lake is built on top of Azure Blob Storage. What does it add?
147. Why would I choose for a Data Lake, instead of regular Blob Storage? What could be my decision criteria?
148. Why would I choose for Blob Storage, instead of Data Lake?
149. Why is it important to support RBAC down to the individual file level?
150. I need to organize my Data Lake. What are some common approaches?

## Azure Databricks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/4-solution-azure-data-brick))

151. What is Azure Databricks and what is Apache Spark?
152. Which role would be using Azure Databricks?
153. When would you choose to implement Azure Databricks?

## Azure Synapse Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/5-solution-azure-synapse-analytics))

154. What is the difference between a serverless pool and a dedicated pool?
155. What do I pay for with Synapse Analytics?
156. Azure Synapse Analytics contains a component to set up pipelines and data flows, which is also part of Azure Data Factory. Why would I use this instead of ADF?
157. Azure Synapse Analytics allows you to setup Spark Pools to process your data. Why would I consider this instead of Azure Databricks?
158. What is Azure Synapse Link for Cosmos DB and what is the use case it tries to solve?

## Strategy for hot/warm/cold data path ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/6-design-strategy-for-hot-warm-cold-data-path))

159. When to use Hot/Warm/Cold data path?

## Azure Stream Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/7-design-azure-stream-analytics-solution-for-data-analysis))

160. When would you consider to use Azure Stream Analytics? (use cases)
161. What is a streaming unit (SU)?
162. What are the main components to setup in Azure Stream Analytics?

# 06 - Design an application architecture solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/))

## Message and event scenarios ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/2-describe-message-event-scenarios))

163. What is the difference between an event and a message and when would you choose for one over the other?
164. Suppose you have a distributed application with a web service that authenticates users. When a user logs on, the web service notifies all the client applications so they can display that user's status as "Online". Is the login notification an example of a message or an event?
165. Let’s suppose a user uploads a new song by using your mobile music-sharing app. The mobile app must send that song to a web API that runs in Azure. The mobile app expects that the web API stores the new song in the database and makes it available to other users. Is this an example of a message or an event?

## Messaging solutions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/3-design-messaging-solution))

166. What are Azure Storage Queues and Azure Service Bus Queues?
167. What is an Azure Service Bus Topic?
168. Which messaging service should you choose? why choose for Azure Service Bus over Azure Storage Queues?
169. What API do you use to interact with Azure Storage Queue?
170. What can you do if the payload of a message is larger than 64 KB in size?

## Event solutions (Event Hub and Event Grid) ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/4-design-event-hub-messaging-solution))

171. What is Event Hub and how does it compare to Azure Event Grid?
172. What is the main consideration for the ‘pull’ model provided by Event Hubs?
173. How does Event Hub handle throughput?
174. How much will you pay for storing 80GB of data per day in Event Hub?
175. How does Event Hub relate to Kafka?
176. What does Event Hub capture provide to you? Why is this important?
177. What can you do if the payload of an event is larger than 256 KB?
178. What is IoT Hub and what capabilities will it add over Event Hub?

## Caching ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/6-design-caching-solution))

179. When would you consider to use an Azure Cache for Redis?

## API Management ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/7-design-api-integration))

180. Why would you introduce an API management solution as implemented by APIM? What are the benefits/use case cases?

## Application lifecycle ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/8-design-automated-app-deployment-solution))

181. What Infrastructure as Code (IaC) technique do you use to automate the provisioning of infrastructure?
182. Why would you use ARM templates versus Bicep?
183. Why would you use Azure DevOps instead of GitHub?
184. Why would you use Terraform instead of ARM/Bicep?
185. What does Azure App Configuration offer to you?

## Application configuration ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/9-configuration-management-solution))

# 07 - Design Authentication and Authorization Solutions ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/))

## Identity and access management ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/2-design-for-identity-access-management))

186. What is the difference between AAD, AAD B2B and AAD B2C
187. What is AADDS?

## Azure Active Directory ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/3-design-for-azure-active-directory))

188. What is Azure AD Connect and what is Azure AD Connect Cloud Sync? What could be a use case to use AAD Connect cloud sync?
189. Is Azure AD Connect one-direction-only or does it support bi-directional replication?
190. Does it make sense to deploy multiple AAD Tenants? Or should you stick with a single tenant?
191. Why should you not synchronize accounts to Azure AD that have high privileges?
192. Is Password Hash Synchronization safe to use?
193. What is that SSO helps you to do?
194. Should you centralize or de-centralize your identity management. Can you do both?

## Azure Active Directory B2B ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/4-design-business-business))

195. Why would you consider Azure AD B2B?
196. When implementing Azure AD B2B, does your partner need to have AAD as well? What identity providers are supported?
197. Can you enforce MFA for guest accounts, even when they do not have this configured?
198. What is an Access Panel?
199. Who can invite guests? Should you centralize / de-centralize?
200. What is a self-service sign-up flow? Can you customize this?

## Azure Active Directory B2C ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/5-design-business-customer))

201. Why would you consider Azure AD B2C?
202. When implementing Azure AD B2B, does your client need to have AAD as well? What identity providers are supported?
203. What is user flow? And can you customize the look and feel of the user interface?
204. Where should I store custom user attributes?

## Conditional access ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/6-design-for-conditional-access))

205. What scenarios can you think of where conditional access would be beneficial?
206. Why does conditional access provide more granular control over the MFA policies?
207. You are not sure about the impact of changing a conditional access policy. What should you use?
208. Which license do you need to use conditional access?
209. You want to prevent people from using older legacy protocols like POPHowever, your CEO is still using an old laptop/software. What are your options?

## Identity protection ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/7-design-for-identity-protection))

210. What's the difference between sign-in risk and user risk?
211. What are some common examples of sign-in risk and user risk?
212. What should you do to enable break-the-glass/emergency access account?

## Access reviews ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/8-design-for-access-reviews))

213. What is an access review and why should you use it?
214. What problem is it trying to solve?
215. What license do you require?
216. Who can conduct a review during an access review?

## Service principals for applications ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/9-design-service-principles))

217. What is a managed identity and what is it trying to solve?
218. What is the difference between a user assigned identity and a system managed identity?
219. What is the Azure Instance Metadata Service, and why is it important in the context of managed identity?
220. What is a service principal?
221. Can you explain the relationship between application objects and service principals?
222. Microsoft identity platform supports two types of permissions - delegated permissions and application permissions. What is used when?

## Azure key vault ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/10-design-for-azure-key-vault))

223. Why use Azure Key Vault?
224. How many Azure Key Vaults do you require for your applications?
225. What is the difference between a key and a secret in Azure Key Vault?
226. What is the difference between a key and a certificate in Azure Key vault?
227. Azure Key Vault has two service tiers - Standard and Premium. Why would you choose one over the other?
228. How can you authenticate against Azure Key Vault? (2 supported modes)

# 08 - Design a solution to log and monitor Azure resources ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/))

## Azure Monitor ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/2-design-for-azure-monitor-data-sources))

229. Azure Monitor collects data automatically from a range of components. Can you share some examples/use cases?
230. Example - you have experienced recently an Azure Storage Account Key leakage. How can you prevent this in future?

## Log Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/3-design-for-log-analytics))

231. How many Log Analytics resources do you need?
232. Would you go for a centralized or decentralized approach? Hybrid?
233. What do you pay for?
234. What is the retention time for log data that has been ingested. Can you change this?
235. How can you integrate logging data from Virtual Machines?
236. What can you do to create a dashboard targeted towards business users, showing them some relevant metrics?
237. You want to prevent users from accessing certain data in you Log Analytics workspace. Is this possible and how?
238. Does Log Analytics have some rate limits applicable?
239. How do you enforce capturing logging from your Azure resources into Log Analytics?

## Azure workbooks and Azure Insights ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/4-design-for-azure-workbooks-insights))

240. What are Azure Workbooks?
241. Why would you consider to implement an Azure Workbook?
242. What is Azure Application Insights and what does it offer on top of Log Analytics?
243. What can you use the monitor your Azure Kubernetes environment?

## Azure Data Explorer ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/5-design-for-azure-data-explorer))

244. What is Azure Data Explorer?
245. What do you pay for?

# 09 - Design a network infrastructure solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/))

## Recommend a network architecture solution based on workload requirements ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/2-recommend-network-architecture-solution-based-workload-requirements))

246. Why would you want to create multiple virtual networks, or create multiple subnets in your VNET?
247. Why does it matter to apply a naming convention when creating virtual networks?
248. Can you deploy resources across multiple regions in the same virtual network?
249. How large should your virtual network's address space be?
250. What is the difference between a network virtual appliance (NVA) like a Firewall and a NSG Network Security Group?
251. What is a hub and spoke topology and why would you consider it? What are the benefits/disadvantages?

## Design for on-premises connectivity to Azure virtual networks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/3-design-for-premises-connectivity-to-azure-virtual-networks))

252. Which Azure VPN Gateway SKU should you implement and why?
253. What is the SLA offered by VPN Gateway and what is/is not included? How can you increase the SLA?
254. Is traffic encrypted over the VPN Gateway?
255. What can you do to troubleshoot your VPN connection?
256. Why would you consider an Express Route?
257. Can you use an Express route and combine it with a VPN Gateway? Why would you do this?
258. What advantage brings Azure Virtual WAN to the table?

## Design for Azure network connectivity services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/4-design-for-azure-network-connectivity-services))

259. When setting up peering between 2 virtual networks, is traffic encrypted?
260. What do you pay for when using VNET Peering?
261. Why would you consider implementing Virtual Network NAT (Network Address Translation)?
262. Why would you consider overriding Azure's default routing? How do you accomplish this?

## Design for application delivery services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/5-design-for-application-delivery-services))

263. Why would you consider to use an Azure CDN Content Delivery Network. What problem does it solve?
264. What possible sources should you consider for Azure CDN?
265. What would you pay for and how does it compare to other services like Azure App Service?
266. What are the differences between Load Balancer, Traffic Manager, Application Gateway and Front Door?

## Design for application protection services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/6-design-for-application-protection-services)))

267. Why would you want to go for Azure DDoS protection Standard instead of the default one?
268. What would you pay for when using this service?
269. What problem is it that Azure Private Link is trying to solve?
270. Should you consider Azure Firewall or go for any other 3rd party firewall technology?
271. What are the advantages and disadvantages of setting up Service Endpoints?
272. What's the difference between Network Security Groups and Application Security Groups
273. What problem is it that Azure Bastion solves?
274. How can you implement Just in Time Access?

# 10 - Design a business continuity solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/))

## Backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/2-design-recovery))

275. What is the difference between RTO and RPO?
276. What are SLA's and why does it matter? Who provides the SLA?
277. How would you calculate the SLA?
278. What is MTBF and MTTR and what would be appropriate values?
279. How do you know that a service/application does (not) reach it's SLA?
280. Why do you need both disaster recovery and backup?
281. Why would you test your disaster recovery?

## Azure Backup ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/3-design-for-azure-backup))

282. What can you backup with Azure Backup?
283. What do you pay for?
284. How much data can you store and for how long?
285. What does it mean to have application consistent backups?
286. Can you backup SQL databases with it?
287. Does it store backups also across regions? Only the region pair or other regions?
288. Why is it important to protect your Azure Backup? How can you accomplish this?

## Azure blob backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/4-design-for-azure-blob-backup-recovery))

289. What are the features you can use with Azure Blob storage to be able to recover data without Azure Backup?
290. Can you perform a Point-in-time restore on Azure Blob storage?
291. Can you use Azure Backup to backup Azure Blob storage? Why would you use/not use this?
292. Can you recover a deleted Azure Storage account?
293. How many years can you configure immutable storage?

## Azure Files backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/5-design-for-azure-files-backup-recovery))

294. What are Azure Files snapshots?
295. How would you automate file share backups?
296. Why should you configure alerting and reporting provided by Azure Backup?
297. Why would you want to perform an on-demand backup of a file share if it is also scheduled?

## Azure virtual machine backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/6-design-for-azure-virtual-machine-backup-recovery))

298. What is the difference between snapshot tier and vault tier?

## Azure SQL backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/7-design-for-azure-sql-backup-recovery))

299. How does Azure SQL perform backups and what's the interval, RPO and RTO?
300. What happens in case a region goes down? Can I restore to another region and who is responsible for this?

## Azure Site Recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/8-design-for-azure-site-recover))

301. Why would you choose Azure Site Recovery over another (3rd-party) solution?
302. Why would you combine Azure Site Recovery with Azure Backup?
