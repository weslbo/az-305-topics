# AZ-305 Discussion Topics

## Table of contents

__Total number of questions:__ 333

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
- [11 - Design a migration solution](#11---design-a-migration-solution-learn-module)

# 01 - Design a governance solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-governance/2-design-for-governance))

## Governance ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/2-design-for-governance))

![whiteboard](/whiteboards/01-governance.png)

1. What is governance and why is it important? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/govern/methodology)
    - Who would be asking for this in your company?
    - At which moment in time would you think about implementing governance?
    - What if you don't implement it?
2. How can you organize your resources? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/govern/guides/standard/)
3. Where should I apply permissions for people to manage resources? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/roles)
    - Think again about the hierarchy. Should your DBA be given permissions at the top of the management groups, or rather at the individual SQL databases?
    - What are the pro's and con's?

## Management Groups ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/3-design-for-management-groups))

![whiteboard](/whiteboards/01-management-groups.png)

1. What are management groups and why should you consider implementing them? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups)
2. How many levels can management groups support? [[doc]](https://docs.microsoft.com/en-us/azure/governance/management-groups/overview)
    - Does it include the tenant root level?
3. Should you go for a deeply nested hierarchy, or for a reasonably flat one? Why? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups)
4. Why should you consider a top-level management group? [[doc]](https://docs.microsoft.com/en-us/learn/modules/design-governance/3-design-for-management-groups)
5. How would you organize your management groups? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups#management-groups-in-the-azure-landing-zone-accelerator)
    - By department/geography/product line/...
6. How do you protect your management groups so that not everyone can create/update them? [[doc]](https://docs.microsoft.com/en-us/azure/governance/management-groups/overview#management-group-access)
    - Who can create them?
    - Who can assign a subscription to a management group?
    - Can I as a subscription owner move my subscription to another management group (and circumvent certain policies)?

## Subscriptions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/4-design-for-subscriptions))

![whiteboard](/whiteboards/01-subscriptions.png)

1. What is an Azure Subscription? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-subscriptions)
2. How many subscriptions do you need across your organization? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/scale-subscriptions)
    - Would you need one, or multiple?
3. Who is responsible for paying the subscription?
    - Somebody's got to pay $$$
    - Do you have agreement with key business stakeholders and are they willing to pay for the services?
4. Which offer do I choose for my subscription? [[doc]](https://azure.microsoft.com/en-us/support/legal/offer-details/)
    - Different customers, different prices...
5. Are there any scale limits to my subscriptions? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/azure-subscription-service-limits)
    - Could be a reason to go for multiple subscription. Do you know which limits exists at the level of a subscription?
6. I need to deploy 30,000 VMs. How many subscriptions do I need?
    - Can you find the answer in the docs?
    - What would be your advice?
7. Should my organization go for a centralized vs decentralized approach? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/manage/centralize-operations)
    - Who will be managing these subscriptions and resources within it?
    - Central IT or decentralize and let the business be agile?
    - Will you put everything under an enterprise agreement?
8. We want to enforce common policies and role assignments across many subscriptions. What should we do? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/decision-guides/policy-enforcement/)
9. My developers want to setup sandboxes so they can experiment, but we want to isolate them from the production environment. What should we consider? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/landing-zone/design-area/resource-org-management-groups)
    - Developers! Developers! Developers!
    - It works on my machine!

## Resource groups ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/5-design-for-resource-groups))

![whiteboard](/whiteboards/01-resource-groups.png)

1. What is a resource group? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/fundamental-concepts)
2. How should I group resources? (by type, location, workload, billing, department, lifecycle, ...) [[doc]](https://docs.microsoft.com/en-us/learn/modules/control-and-organize-with-azure-resource-manager/2-principles-of-resource-groups)
3. I have a resource group in WESTEU. Can I deploy resources in NORTHEU? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/manage-resource-groups-portal#what-is-a-resource-group)
    - Can I prevent his?
4. Can I move resources between resource groups? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/move-resource-group-and-subscription) [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/move-support-resources)
    - In case it's not possible, what would be my approach?
5. Can I nest resource groups?
    - Would this make sense to you?
6. Can I deploy a resource in multiple resource groups?
    - for example - Azure Traffic Manager...
7. Should I apply permissions and at what level?
    - Your DBA should get access to all SQL Databases. At which level or you going to assign RBAC?
    - What role?
    - Will you need a custom role?
8. I don't want anyone to delete my central Azure Firewall. What can I do? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/lock-resources?tabs=json)
    - Deleting my Azure Firewall would make my whole environment pretty useless!

## Resource tags? ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/6-design-for-resource-tags))

![whiteboard](/whiteboards/01-resource-tags.png)

1. What's the purpose of resource tags? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-resources?tabs=json)
2. How many tags can I apply to a resource? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-resources?tabs=json)
    - What's the maximum?
    - Should you go for the maximum?
3. If I apply a tag at the level of a resource group, will it inherit down to the individual resource? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-policies)
    - In case the answer is no, what would be the recommended solution?
4. Can you come up with some examples where you could leverage tags on resources? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/decision-guides/resource-tagging/?toc=/azure/azure-resource-manager/management/toc.json)
    - functional, classification, accounting, partnership, purpose
    - how could this fit in your company setup?
5. Will you implement a chargeback or show back accounting system?
    - Will you need to associate resources with accounting information for departments, business groups, and teams in more detail than a simple subscription-level breakdown allows?
6. Does tagging need to represent details such regulatory compliance requirements for a resource?
    - What about operational details such as uptime requirements, patching schedules, or security requirements?
7. What can I do to enforce tagging [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-policies#policy-definitions)
    - eg - cost center is required!
8. Are there resources which do not support tagging? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/tag-support)
    - Can you find one in the documentation?
9. What tags will be required for all resources based on centralized IT policy? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/resource-tagging)
    - What tags will be optional?
    - Are individual teams allowed to implement their own custom tagging schemes?

## Azure Policy ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/7-design-for-azure-policy))

![whiteboard](/whiteboards/01-policy.png)

1. What is an Azure Policy? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview)
2. At what level should you apply an Azure Policy? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview#assignments)
    - Can you apply this to an individual resource?
3. I have multiple Azure Policies to enforce. Any recommendations? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/initiative-definition-structure) [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/samples/built-in-initiatives)
4. When are Azure Policies evaluated? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview#understand-evaluation-outcomes) [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/evaluate-impact) [[doc]](https://docs.microsoft.com/en-us/learn/modules/design-governance/7-design-for-azure-policy)
    - Timing is everything!
5. What should happen when the resource is not compliant against the policy? What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/effects)
6. Can I automatically remediate the resource to become compliant? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/concepts/event-overview) [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/tutorials/route-state-change-events) [[doc]](https://docs.microsoft.com/en-us/azure/logic-apps/policy-reference)
    - What technology could I use to support the remediation?
    - What do I need to think about?

## RBAC (Role Based Access Control) ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/8-design-for-role-based-access-control))

![whiteboard](/whiteboards/01-rbac.png)

1. Who should I give access, and at what level? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/roles)
    - Think again about the Database Administrator in your company.
    - Should everyone be an owner/contributor?
2. Should I assign roles to users or groups? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/best-practices)
    - How would this make my life easier?
3. Should everyone be an owner/contributor? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/deny-assignments)
    - Can I explicitly deny access?
    - I don't trust my colleagues ;-)
4. When should you create a custom role? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/custom-roles) [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/considerations/roles#use-custom-roles)
    - Azure has hundreds of roles out of the box...
5. What happens if roles are overlapping? [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/overview#how-azure-rbac-determines-if-a-user-has-access-to-a-resource)
    - I got assigned permissions at different levels... Now what?
6. How to allow some users to control the virtual machines in an environment but prevent them from modifying networking and other resources in the same resource group or Azure subscription?
7. Can you assign a role to a non-user? (aka service account?) [[doc]](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-assignments-steps)
    - I want to make use of GitHub actions and automate the deployment of ARM templates...
8. How does Azure Policy differ from RBAC? [[doc]](https://docs.microsoft.com/en-us/azure/governance/policy/overview#azure-policy-and-azure-rbac)
    - What's the purpose of each of these?

## Azure Blueprints ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-governance/9-design-for-azure-blueprints))

![whiteboard](/whiteboards/01-blueprints.png)

1. What is an Azure Blueprint and why would I consider this? [[doc]](https://docs.microsoft.com/en-us/azure/governance/blueprints/overview)
2. What elements are part of an Azure Blueprint?
    - Can I / Should I include ARM templates?
    - Are there alternatives?
3. How do we enforce compliance? [[doc]](https://docs.microsoft.com/en-us/azure/governance/blueprints/samples/)

# 02 - Design a compute solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/))

![whiteboard](/whiteboards/02-compute.png)

## Virtual Machines ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/3-design-for-azure-virtual-machine-solutions))

![whiteboard](/whiteboards/02-vm.png)

1. What could be reasons to choose for Virtual Machines instead of PaaS services? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/compute-decision-tree)
2. Who is responsible for your VM? Microsoft or the customer? [[doc]](https://docs.microsoft.com/en-us/azure/security/fundamentals/shared-responsibility)
3. Can you run any VM in any region? What about pricing? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/troubleshooting/error-sku-not-available?tabs=azure-cli)
4. I need to run a database. Which VM size should I use? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/sizes)
5. Managed disks versus unmanaged disks? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/faq-for-disks) [[doc]](https://buildwindows.wordpress.com/2017/05/31/azure-managed-vs-unmanaged-disks-the-choice/)
6. I need to set up a Linux server with an Apache web server, a MySQL Database and PHP installed already on it. What are my options? [[doc]](https://azuremarketplace.microsoft.com/en-us/) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/tutorial-lamp-stack)
7. Why should I consider creating my own disk images? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/windows/capture-image-resource) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/windows/create-vm-generalized-managed)

## Virtual Machine Scale Sets ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/3-design-for-azure-virtual-machine-solutions))

![whiteboard](/whiteboards/02-vmss.png)

1. What are Virtual Machine Scale Sets? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machine-scale-sets/overview)
2. My VM Scale Set needs high availability. What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/availability?toc=/azure/virtual-machine-scale-sets/toc.json)
3. I need to deploy my application to VM Scale Set. What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/shared-image-galleries?toc=/azure/virtual-machine-scale-sets/windows/toc.json) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/extensions/custom-script-linux)

## Azure Batch ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/4-design-for-azure-batch-solutions))

![whiteboard](/whiteboards/02-batch.png)

1. What is Azure Batch? [[doc]](https://docs.microsoft.com/en-us/azure/batch/batch-technical-overview)
2. What are some use cases to consider Azure Batch? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/infrastructure/video-rendering) [[doc]](https://docs.microsoft.com/en-us/gaming/azure/reference-architectures/multiplayer-synchronous-batch) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/ai/batch-scoring-r-models) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/solution-ideas/articles/big-compute-with-azure-batch) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/infrastructure/hpc-cfd)
3. What is the difference between a batch Pool, Node and Job? [[doc]](https://docs.microsoft.com/en-us/azure/batch/nodes-and-pools) [[doc]](https://docs.microsoft.com/en-us/azure/batch/jobs-and-tasks)

## Azure App Service ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/5-design-for-azure-app-services-solutions))

![whiteboard](/whiteboards/02-app-service.png)

1. What is it that I pay for with an Azure App Service? [[doc]](https://docs.microsoft.com/en-us/azure/app-service/overview-hosting-plans#how-much-does-my-app-service-plan-cost) [[doc]](https://docs.microsoft.com/en-us/azure/app-service/overview-manage-costs#understand-the-full-billing-model-for-azure-app-service)
2. Why would I consider deployment slots? [[doc]](https://docs.microsoft.com/en-us/azure/app-service/deploy-staging-slots)
3. My developers have difficulties implementing authentication and authorization. Can App Service provide this capability? [[doc]](https://docs.microsoft.com/en-us/azure/app-service/overview-authentication-authorization)
4. I want to run a web app implemented in Go (Golang) in Azure App Service but find out that this language is not supported. What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/app-service/quickstart-custom-container?tabs=dotnet&pivots=container-linux)
5. What are WebJobs? Why would I use these or should I use something different? [[doc]](https://docs.microsoft.com/en-us/azure/app-service/webjobs-create) [[doc]](https://docs.microsoft.com/en-us/azure/azure-functions/functions-compare-logic-apps-ms-flow-webjobs)

## Container Instances ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/6-design-for-azure-container-instances-solutions))

![whiteboard](/whiteboards/02-container-instances.png)

1. What are Azure Container Instances and why should I use it? [[doc]](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-overview)
2. When/Why should I NOT use it? [[doc]](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-orchestrator-relationship) [[doc]](https://docs.microsoft.com/en-us/azure/container-apps/compare-options)
3. What are multi-container groups? [[doc]](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-container-groups)
4. Why should I consider containers instead of Virtual Machines? (isolation, operating system, deployment, persistent storage, fault tolerance) [[doc]](https://docs.microsoft.com/en-us/virtualization/windowscontainers/about/containers-vs-vm)
5. What is a Virtual Kubelet? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/solution-ideas/articles/scale-using-aks-with-aci) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/hybrid/hybrid-containers)

## Azure Kubernetes ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/7-design-for-azure-kubernetes-solutions))

![whiteboard](/whiteboards/02-kubernetes.png)

1. What is Azure Kubernetes? [[doc]](https://azure.microsoft.com/en-us/resources/kubernetes-learning-path/)
2. Who needs to manage the Kubernetes cluster? [[doc]](https://docs.microsoft.com/en-us/azure/aks/concepts-clusters-workloads)
3. What do you pay for? [[doc]](https://azure.microsoft.com/en-us/pricing/details/kubernetes-service/)
4. Can you deploy multiple Virtual Machine sizes/types? [[doc]](https://docs.microsoft.com/en-us/azure/aks/use-multiple-node-pools)
5. What methods exist to scale your application running on AKS? [[doc]](https://docs.microsoft.com/en-us/azure/aks/concepts-scale)
6. How can I isolate certain workloads inside my AKS cluster? [[doc]](https://docs.microsoft.com/en-us/azure/aks/operator-best-practices-cluster-isolation) [[doc]](https://docs.microsoft.com/en-us/azure/aks/concepts-clusters-workloads#namespaces)
7. What technology can I use when my application requires persistent storage? [[doc]](https://docs.microsoft.com/en-us/azure/aks/concepts-storage)
8. What are 2 ways of synchronizing storage across clusters? [[doc]](https://docs.microsoft.com/en-us/azure/aks/operator-best-practices-multi-region#infrastructure-based-asynchronous-replication) [[doc]](https://docs.microsoft.com/en-us/azure/aks/operator-best-practices-multi-region#application-based-asynchronous-replication)
9. Can my application running on AKS connect to on-premise resources? [[doc]](https://docs.microsoft.com/en-us/azure/aks/concepts-network)
10. I'm concerned about vulnerabilities and outdated base images. What can I do about this? [[doc]](https://docs.microsoft.com/en-us/azure/defender-for-cloud/defender-for-containers-introduction?tabs=defender-for-container-arch-aks) [[doc]](https://docs.microsoft.com/en-us/azure/aks/concepts-security)
11. Can I deploy multiple AKS clusters across non-paired regions? [[doc]](https://docs.microsoft.com/en-us/azure/aks/operator-best-practices-multi-region)

## Azure Functions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/8-design-for-azure-functions-solutions))

![whiteboard](/whiteboards/02-functions.png)

1. Why would I consider Azure Functions? Do you have some scenarios? [[doc]](https://docs.microsoft.com/en-us/dotnet/architecture/serverless/) [[doc]](https://docs.microsoft.com/en-us/dotnet/architecture/serverless/serverless-design-examples) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/serverless/web-app)
2. What do I pay for when using Serverless Functions? [[doc]](https://docs.microsoft.com/en-us/azure/azure-functions/pricing)
3. What are durable functions and why should I consider these? [[doc]](https://docs.microsoft.com/en-us/dotnet/architecture/serverless/durable-azure-functions) [[doc]](https://docs.microsoft.com/en-us/azure/azure-functions/durable/durable-functions-overview?tabs=csharp)
4. What are the different hosting plans available for Azure Functions and why should I choose for one over the other? [[doc]](https://docs.microsoft.com/en-us/azure/azure-functions/functions-scale)
5. Why would I consider to use a Premium plan for Azure Functions? [[doc]](https://docs.microsoft.com/en-us/azure/azure-functions/functions-premium-plan?tabs=portal)

## Logic Apps ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-compute-solution/9-design-for-logic-app-solutions))

![whiteboard](/whiteboards/02-logic-apps.png)

1. Why would I consider Logic Apps? Do you have some scenarios? [[doc]](https://docs.microsoft.com/en-us/dotnet/architecture/serverless/logic-apps) [[doc]](https://docs.microsoft.com/en-us/azure/logic-apps/logic-apps-overview) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/enterprise-integration/basic-enterprise-integration) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/integration/logic-apps-data-integration) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/hybrid/gateway-logic-apps)
2. My application requires some complex business rules. Should I use Logic Apps? [[doc]](https://docs.microsoft.com/en-us/azure/logic-apps/logic-apps-serverless-overview)
3. What do I pay for when using Logic Apps? [[doc]](https://docs.microsoft.com/en-us/azure/logic-apps/logic-apps-pricing) [[doc]](https://azure.microsoft.com/en-us/pricing/details/logic-apps/)
4. Can I run a Logic App on a separate plan? Why would I do this? [[doc]](https://docs.microsoft.com/en-us/azure/logic-apps/single-tenant-overview-compare)
5. What are some differences between a Logic App and Durable Functions? [[doc]](https://docs.microsoft.com/en-us/azure/azure-functions/functions-compare-logic-apps-ms-flow-webjobs#compare-azure-functions-and-azure-logic-apps)

# 03 - Design a non-relational data storage solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/))

## Data Storage ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/2-design-for-data-storage))

![whiteboard](/whiteboards/03-data-storage.png)

1. What is the difference between Structured/Unstructured/Semi-structured? [[doc]](https://docs.microsoft.com/en-us/learn/modules/choose-storage-approach-in-azure/2-classify-data)
2. What are your options for storing unstructured data in Azure? Why would you choose one over the other? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/data-store-decision-tree)

## Azure Storage ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/3-design-for-azure-storage-accounts))

![whiteboard](/whiteboards/03-azure-storage.png)

1. When should you NOT choose a Standard General Purpose V2 storage account? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-account-overview)
2. How many storage accounts do you actually need? What should you consider? [[doc]](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/3-design-for-azure-storage-accounts)
3. What does the SLA of 99.9% or 99.99% mean in relation to an Azure Storage account? [[doc]](https://azure.microsoft.com/en-us/support/legal/sla/storage/v1_5/)
4. Does replication between data centers and regions happen synchronous? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy)
5. Can I read from a secondary region? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy#read-access-to-data-in-the-secondary-region)
6. Under what circumstances can you have loss of data, even when replication has been setup? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-redundancy#redundancy-in-a-secondary-region)
7. Can I switch between replication types? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/redundancy-migration?toc=%2Fazure%2Fstorage%2Fblobs%2Ftoc.json&tabs=portal)
8. Will Microsoft fail over or is the customer who initiates the fail over to another region? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-disaster-recovery-guidance?toc=/azure/storage/blobs/toc.json)
9. Why would I consider the cool storage and archive storage tiers? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/access-tiers-overview)
10. How many hours can it take to rehydrate archived blobs? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/archive-rehydrate-overview#rehydration-priority)
11. Why would I use immutable storage for Azure Storage? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/immutable-policy-configure-version-scope?tabs=azure-portal) [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/immutable-policy-configure-container-scope?tabs=azure-portal)
12. What is the difference between time-based retention policies and legal hold policies? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/immutable-time-based-retention-policy-overview) [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/immutable-legal-hold-overview)
13. Which data sets and policies would be most helpful in your organization?

## Azure Files ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/6-design-for-azure-files))

![whiteboard](/whiteboards/03-azure-files.png)

1. When would you use Azure Files instead of Azure Blob storage? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-introduction#example-scenarios)
2. Which protocols are supported with Azure Files? [[doc]](https://docs.microsoft.com/en-us/azure/storage/files/storage-files-introduction)
3. What is file sync and why do you need it? [[doc]](https://docs.microsoft.com/en-us/azure/storage/file-sync/file-sync-introduction) [[doc]](https://docs.microsoft.com/en-us/azure/storage/file-sync/file-sync-planning)
4. Which file storage tiers exists and which one would you choose in the following scenarios [[doc]](https://docs.microsoft.com/en-us/azure/storage/files/storage-files-planning#storage-tiers)
    - You have highly I/O-intensive workloads, with high throughput and low latency
    - You need storage optimized for general purpose file sharing scenarios such as team shares and Azure File Sync
    - You need cost-efficient storage optimized for online archive storage scenarios
    - You have transaction heavy workloads and applications that require file storage and backend storage
5. Why would I consider Azure NetApp files? [[doc]](https://docs.microsoft.com/en-us/azure/azure-netapp-files/azure-netapp-files-introduction) [[doc]](https://docs.microsoft.com/en-us/azure/storage/files/storage-files-netapp-comparison)

## Azure Disks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/7-design-for-azure-disk-solutions))

![whiteboard](/whiteboards/03-azure-disks.png)

1. Azure offers Ultra-disk, Premium SSD, Standard SSD and Standard HDD disk types. What could be a valid scenario to choose one over the other? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types#disk-type-comparison)
2. Why would I consider to change disk caching from None to ReadOnly or Read/Write? How should I configure these when implementing a SQL Server Database? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/premium-storage-performance#disk-caching) [[doc]](https://docs.microsoft.com/en-us/learn/modules/caching-and-performance-azure-storage-and-disks/3-enable-and-configure-azure-vm-disk-cache-by-using-the-azure-portal) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/virtual-machines/windows/performance-guidelines-best-practices-storage) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/disks-performance#virtual-machine-uncached-vs-cached-limits)
3. Encryption types for Managed Azure Disks includes Azure Disk Encryption (ADE), Server-Side Encryption (SSE) and encryption at host. What's the difference and should you combine these? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/disk-encryption-overview)
4. What is the difference between an image and a snapshot? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/shared-image-galleries) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/disks-incremental-snapshots?tabs=azure-cli)
5. Can you share multiple disks across VM's? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/disks-shared)
6. How can you improve performance by implementing multiple disks? [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/premium-storage-performance#disk-striping)

## Storage security ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-non-relational-data/8-design-for-storage-security))

![whiteboard](/whiteboards/03-storage-security.png)

1. Why should I never hand out the Azure Storage Account Key? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-account-keys-manage?tabs=azure-portal)
2. What is a Shared Access Signature and at which level can I create it? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-sas-overview?toc=/azure/storage/blobs/toc.json)
3. Should I protect my storage account at the network level? What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-network-security?toc=%2Fazure%2Fstorage%2Fblobs%2Ftoc.json&tabs=azure-portal) [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-private-endpoints?toc=/azure/storage/blobs/toc.json) [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/transport-layer-security-configure-minimum-version?toc=%2Fazure%2Fstorage%2Fblobs%2Ftoc.json&tabs=portal) [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-require-secure-transfer?toc=/azure/storage/blobs/toc.json)
4. Can I bring my own encryption key? How granular can I implement this? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-service-encryption?toc=/azure/storage/blobs/toc.json) [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/customer-managed-keys-overview?toc=/azure/storage/blobs/toc.json) [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/encryption-scope-overview)

# 04 - Design a data storage solution for relational data ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data))

## Azure SQL Database ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/))

![whiteboard](/whiteboards/04-azure-sql.png)

1. Azure SQL Database can be hosted in many ways. What could be my decision criteria? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/azure-sql-iaas-vs-paas-what-is-overview?toc=/azure/cloud-adoption-framework/toc.json&bc=/azure/cloud-adoption-framework/_bread/toc.json)
2. What are elastic pools? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview)
3. How can Elastic pools help you achieve vertical scaling? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-scale-introduction#horizontal-and-vertical-scaling)
4. What is the difference between DTU and the vCore model? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/service-tiers-dtu) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/service-tiers-sql-database-vcore)
5. When should I consider the serverless compute tier for Azure SQL Database? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/serverless-tier-overview)
6. Why would I choose for the Business Critical tier instead of the General Purpose Tier? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/service-tiers-general-purpose-business-critical)
7. Why would I consider the Hyperscale tier instead of a Dedicated pool in Azure Synapse Analytics? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/service-tier-hyperscale) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/service-tier-hyperscale-frequently-asked-questions-faq#how-can-i-choose-between-azure-synapse-analytics-and-azure-sql-database-hyperscale-)
8. There are 2 types of horizontal scaling - sharding and read-scale-out. [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/scale-resources) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/read-scale-out)
9. Azure SQL Database offers the following capabilities for recovering from an outage. Why would I choose for one over the other? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/disaster-recovery-guidance)
    - Active geo-replication
    - Auto-failover groups
    - Geo-restore
    - Zone-redundant databases
10. What encryption mechanisms should I consider when data is at rest, in motion and in process [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/security-overview#transport-layer-security-encryption-in-transit) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/transparent-data-encryption-tde-overview?tabs=azure-portal) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/always-encrypted-landing) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/dynamic-data-masking-overview)
11. Azure SQL Database supports SQL authencation and Azure Active Directory authentication. Why should I consider AAD authentication? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/authentication-aad-overview)

## Azure SQL Edge ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/8-design-for-azure-sql-edge))

![whiteboard](/whiteboards/04-azure-sql-edge.png)

1. When would you consider to use Azure SQL Edge? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql-edge/overview) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/solution-ideas/articles/data-storage-edge)
2. What technology do you need to deploy Azure SQL Edge on? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql-edge/disconnected-deployment) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql-edge/deploy-kubernetes)

## Azure Cosmos DB ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-storage-solution-for-relational-data/9-design-for-azure-cosmos))

1. When would you consider to use Azure Cosmos DB? [[doc]](https://docs.microsoft.com/en-us/azure/cosmos-db/introduction#solutions-that-benefit-from-azure-cosmos-db) [[doc]](https://docs.microsoft.com/en-us/azure/cosmos-db/choose-api)
2. Table data can be stored as part of Azure Table Storage or inside Azure Cosmos DB. Why would you chose one over the other? [[doc]](https://docs.microsoft.com/en-us/azure/cosmos-db/table/table-support)
3. How can you manage performance of an Azure Cosmos DB? [[doc]](https://docs.microsoft.com/en-us/azure/cosmos-db/request-units) [[doc]](https://docs.microsoft.com/en-us/azure/cosmos-db/throughput-serverless)

# 05 - Design a data integration solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/))

## Azure Data Factory ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/2-solution-azure-data-factory))

![whiteboard](/whiteboards/05-data-factory.png)

1. Why would you consider Azure Data Factory over SSIS (SQL Server Integration Services)? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/data-guide/technology-choices/pipeline-orchestration-data-movement) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/data/enterprise-bi-adf) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/data/hybrid-etl-with-adf)
2. What do you pay for when using Azure Data Factory? [[doc]](https://docs.microsoft.com/en-us/azure/data-factory/plan-manage-costs) [[doc]](https://docs.microsoft.com/en-us/azure/data-factory/pricing-concepts)
3. What component of Azure Data Factory would you consider to perform data transformations? What alternatives are there? [[doc]](https://docs.microsoft.com/en-us/azure/data-factory/transform-data)
4. What is a Self-Hosted Integration Runtime and why do you need it? [[doc]](https://docs.microsoft.com/en-us/azure/data-factory/concepts-integration-runtime#self-hosted-integration-runtime) [[doc]](https://docs.microsoft.com/en-us/azure/data-factory/create-self-hosted-integration-runtime?tabs=data-factory)

## Azure Data Lake ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/3-solution-azure-data-lake))

![whiteboard](/whiteboards/05-data-lake.png)

1. Azure Data Lake is built on top of Azure Blob Storage. What does it add? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-introduction#key-features-of-data-lake-storage-gen2)
2. Why would I choose for a Data Lake, instead of regular Blob Storage? What could be my decision criteria? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-namespace) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/data-guide/scenarios/data-lake)
3. Why would I choose for Blob Storage, instead of Data Lake? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-feature-support-in-storage-accounts) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/guide/technology-choices/data-store-decision-tree)
4. Why is it important to support RBAC down to the individual file level? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-access-control-model#access-control-lists-acls)
5. I need to organize my Data Lake. What are some common approaches? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-best-practices#directory-structure) [[doc]](https://docs.microsoft.com/en-us/azure/databricks/delta/delta-intro) [[doc]](https://docs.microsoft.com/en-us/learn/modules/describe-azure-databricks-delta-lake-architecture/2-describe-bronze-silver-gold-architecture)

## Azure Databricks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/4-solution-azure-data-brick))

![whiteboard](/whiteboards/05-databricks.png)

1. What is Azure Databricks and what is Apache Spark? [[doc]](https://docs.microsoft.com/en-us/azure/databricks/scenarios/what-is-azure-databricks) [[doc]](https://docs.microsoft.com/en-us/azure/databricks/getting-started/overview) [[doc]](https://docs.microsoft.com/en-us/azure/databricks/getting-started/spark/)
2. Which role would be using Azure Databricks? [[doc]](https://docs.microsoft.com/en-us/learn/modules/describe-azure-databricks/2-explain?ns-enrollment-type=LearningPath&ns-enrollment-id=learn.wwl.perform-data-science-azure-databricks)
3. When would you choose to implement Azure Databricks? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/mlops/aml-decision-tree)

## Azure Synapse Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/5-solution-azure-synapse-analytics))

![whiteboard](/whiteboards/05-synapse.png)

1. What is the difference between a serverless pool and a dedicated pool? [[doc]](https://docs.microsoft.com/en-us/azure/synapse-analytics/sql-data-warehouse/sql-data-warehouse-overview-what-is?context=/azure/synapse-analytics/context/context) [[doc]](https://docs.microsoft.com/en-us/azure/synapse-analytics/sql/on-demand-workspace-overview) [[doc]](https://docs.microsoft.com/en-us/azure/synapse-analytics/sql/overview-features)
2. What do I pay for with Synapse Analytics? [[doc]](https://azure.microsoft.com/en-us/pricing/details/synapse-analytics/)
3. Azure Synapse Analytics contains a component to set up pipelines and data flows, which is also part of Azure Data Factory. Why would I use this instead of ADF? [[doc]](https://docs.microsoft.com/en-us/azure/synapse-analytics/data-integration/concepts-data-factory-differences)
4. Azure Synapse Analytics allows you to setup Spark Pools to process your data. Why would I consider this instead of Azure Databricks? [[doc]](https://docs.microsoft.com/en-us/answers/questions/587071/differnce-between-synapse-and-databricks.html)
5. What is Azure Synapse Link for Cosmos DB and what is the use case it tries to solve? [[doc]](https://docs.microsoft.com/en-us/azure/cosmos-db/synapse-link)

## Strategy for hot/warm/cold data path ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/6-design-strategy-for-hot-warm-cold-data-path))

![whiteboard](/whiteboards/05-hot-cold-warm.png)

1. When to use Hot/Warm/Cold data path? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/data-guide/big-data/) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/data-guide/big-data/batch-processing) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/data-guide/big-data/real-time-processing)

## Azure Stream Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-data-integration/7-design-azure-stream-analytics-solution-for-data-analysis))

![whiteboard](/whiteboards/05-stream-analytics.png)

1. When would you consider to use Azure Stream Analytics? (use cases) [[doc]](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-solution-patterns) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/data-guide/technology-choices/stream-processing) [[doc]](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-introduction) [[doc]](https://azure.microsoft.com/case-studies/?service=stream-analytics)
2. What is a streaming unit (SU)? [[doc]](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-streaming-unit-consumption)
3. What are the main components to setup in Azure Stream Analytics? [[doc]](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-add-inputs) [[doc]](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-define-outputs) [[doc]](https://docs.microsoft.com/en-us/stream-analytics-query/stream-analytics-query-language-reference)

# 06 - Design an application architecture solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/))

## Message and event scenarios ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/2-describe-message-event-scenarios))

![whiteboard](/whiteboards/06-message-or-event.png)

1. What is the difference between an event and a message and when would you choose for one over the other? [[doc]](https://docs.microsoft.com/en-us/azure/event-grid/compare-messaging-services#event-vs-message-services)
2. Suppose you have a distributed application with a web service that authenticates users. When a user logs on, the web service notifies all the client applications so they can display that user's status as "Online". Is the login notification an example of a message or an event?
3. Let’s suppose a user uploads a new song by using your mobile music-sharing app. The mobile app must send that song to a web API that runs in Azure. The mobile app expects that the web API stores the new song in the database and makes it available to other users. Is this an example of a message or an event?

## Messaging solutions ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/3-design-messaging-solution))

![whiteboard](/whiteboards/06-messaging.png)

1. What are Azure Storage Queues and Azure Service Bus Queues and how would you compare them? [[doc]](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-azure-and-service-bus-queues-compared-contrasted)
2. What is an Azure Service Bus Topic? [[doc]](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-queues-topics-subscriptions#topics-and-subscriptions)
3. What API do you use to interact with Azure Storage Queue? [[doc]](https://docs.microsoft.com/en-us/azure/storage/queues/reference)
4. What can you do if the payload of a message is larger than 64 KB in size? [[doc]](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-azure-and-service-bus-queues-compared-contrasted#capacity-and-quotas) [[doc]](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-premium-messaging#large-messages-support)

## Event solutions (Event Hub and Event Grid) ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/4-design-event-hub-messaging-solution))

![whiteboard](/whiteboards/06-events.png)

1. What is Event Hub and how does it compare to Azure Event Grid? [[doc]](https://docs.microsoft.com/en-us/azure/event-grid/overview) [[doc]](https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-about) [[doc]](https://docs.microsoft.com/en-us/azure/event-grid/compare-messaging-services#comparison-of-services)
2. What is the main consideration for the ‘pull’ model provided by Event Hubs? [[doc]](https://docs.microsoft.com/en-us/learn/modules/choose-a-messaging-model-in-azure-to-connect-your-services/5-choose-azure-event-hubs)
3. How does Event Hub handle throughput? [[doc]](https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-scalability)
4. How much will you pay for storing 80GB of data per day in Event Hub? [[doc]](https://azure.microsoft.com/en-us/pricing/details/event-hubs/)
5. How does Event Hub relate to Kafka? [[doc]](https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-for-kafka-ecosystem-overview)
6. What does Event Hub capture provide to you? Why is this important? [[doc]](https://docs.microsoft.com/en-us/azure/event-hubs/event-hubs-capture-overview)
7. What can you do if the payload of an event is larger than 256 KB? [[doc]](https://docs.microsoft.com/en-us/azure/event-hubs/compare-tiers)
8. What is IoT Hub and what capabilities will it add over Event Hub? [[doc]](https://docs.microsoft.com/en-us/azure/iot-hub/iot-concepts-and-iot-hub) [[doc]](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-compare-event-hubs)

## Caching ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/6-design-caching-solution))

![whiteboard](/whiteboards/06-caching.png)

1. When would you consider to use an Azure Cache for Redis? [[doc]](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-overview)

## API Management ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/7-design-api-integration))

![whiteboard](/whiteboards/06-api-management.png)

1. Why would you introduce an API management solution as implemented by APIM? What are the benefits/use case cases? [[doc]](https://docs.microsoft.com/en-us/azure/api-management/api-management-key-concepts) [[doc]](https://azure.microsoft.com/mediahandler/files/resourcefiles/api-design/Azure_API-Design_Guide_eBook.pdf) [[doc]](https://azure.microsoft.com/mediahandler/files/resourcefiles/apis-microservices-ebook/Azure_API-Microservices_eBook.pdf)

## Application lifecycle ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/8-design-automated-app-deployment-solution))

![whiteboard](/whiteboards/06-app-lifecycle.png)

1. What Infrastructure as Code (IaC) technique do you use to automate the provisioning of infrastructure? [[doc]](https://docs.microsoft.com/en-us/devops/deliver/what-is-infrastructure-as-code) [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/overview) [[doc]](https://docs.microsoft.com/en-us/learn/paths/fundamentals-bicep/) [[doc]](https://docs.microsoft.com/en-us/azure/developer/terraform/overview) [[doc]](https://docs.microsoft.com/en-us/azure/developer/ansible/overview) [[doc]](https://docs.microsoft.com/en-us/azure/developer/chef/overview)
2. Why would you use ARM templates versus Bicep? [[doc]](https://docs.microsoft.com/en-us/azure/azure-resource-manager/bicep/overview)
3. Why would you use Azure DevOps instead of GitHub? [[doc]](https://docs.microsoft.com/en-us/dotnet/architecture/devops-for-aspnet-developers/actions-vs-pipelines)
4. Why would you use Terraform instead of ARM/Bicep? [[doc]](https://docs.microsoft.com/en-us/dotnet/architecture/cloud-native/infrastructure-as-code)

## Application configuration ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-application-architecture/9-configuration-management-solution))

1. What does Azure App Configuration offer to you? [[doc]](https://docs.microsoft.com/en-us/azure/azure-app-configuration/overview)

# 07 - Design Authentication and Authorization Solutions ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/))

## Identity and access management ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/2-design-for-identity-access-management))

1. What is the difference between AAD, AAD B2B and AAD B2C [[doc]](https://azure.microsoft.com/mediahandler/files/resourcefiles/cloud-identity-and-access-management/Cloud_Identity_and_Access_Management_infographic.pdf/) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/compare-with-b2c)
2. What is AADDS? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory-domain-services/scenarios)

## Azure Active Directory ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/3-design-for-azure-active-directory))

1. What is Azure AD Connect and what is Azure AD Connect Cloud Sync? What could be a use case to use AAD Connect cloud sync? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/hybrid/whatis-azure-ad-connect) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/cloud-sync/what-is-cloud-sync)
2. Is Azure AD Connect one-direction-only or does it support bi-directional replication? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/authentication/tutorial-enable-sspr-writeback) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/hybrid/how-to-connect-group-writeback) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/hybrid/reference-connect-sync-attributes-synchronized#exchange-hybrid-writeback)
3. Does it make sense to deploy multiple AAD Tenants? Or should you stick with a single tenant? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/hybrid/plan-connect-topologies) [[doc]](https://docs.microsoft.com/en-us/microsoft-365/education/deploy/design-multi-tenant-architecture#common-reasons-for-multiple-tenants)
4. Why should you not synchronize accounts to Azure AD that have high privileges? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/roles/security-planning)
5. Is Password Hash Synchronization safe to use? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/hybrid/how-to-connect-password-hash-synchronization)
6. What is that SSO helps you to do? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/what-is-single-sign-on)
7. Should you centralize or de-centralize your identity management. Can you do both? [[doc]](https://docs.microsoft.com/en-us/learn/modules/implement-initial-configuration-of-azure-active-directory/6-configure-delegation-administrative-units?ns-enrollment-type=LearningPath)

## Azure Active Directory B2B ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/4-design-business-business))

1. Why would you consider Azure AD B2B? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/compare-with-b2c)
2. When implementing Azure AD B2B, does your partner need to have AAD as well? What identity providers are supported? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/what-is-b2b#collaborate-with-any-partner-using-their-identities)
3. Can you enforce MFA for guest accounts, even when they do not have this configured? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/b2b-tutorial-require-mfa)
4. What is an Access Panel? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/what-is-access-management) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/manage-apps/my-apps-deployment-plan)
5. Who can invite guests? Should you centralize / de-centralize? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/add-users-administrator) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/add-users-information-worker) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/invite-internal-users) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/add-user-without-invite)
6. What is a self-service sign-up flow? Can you customize this? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/self-service-sign-up-user-flow)

## Azure Active Directory B2C ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/5-design-business-customer))

1. Why would you consider Azure AD B2C? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory-b2c/overview) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/external-identities/compare-with-b2c?bc=/azure/active-directory-b2c/bread/toc.json&toc=/azure/active-directory-b2c/TOC.json#compare-external-identities-solutions)
2. When implementing Azure AD B2B, does your client need to have AAD as well? What identity providers are supported? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory-b2c/technical-overview#sign-in-with-external-identity-providers)
3. What is user flow? And can you customize the look and feel of the user interface? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory-b2c/user-flow-overview)
4. Where should I store custom user attributes? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory-b2c/configure-user-input?pivots=b2c-user-flow)

## Conditional access ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/6-design-for-conditional-access))

1. What scenarios can you think of where conditional access would be beneficial? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/conditional-access/plan-conditional-access)
2. Why does conditional access provide more granular control over the MFA policies? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/authentication/howto-mfa-userstates)
3. You are not sure about the impact of changing a conditional access policy. What should you use? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/conditional-access/concept-conditional-access-report-only)
4. Which license do you need to use conditional access? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/conditional-access/overview#license-requirements)
5. You want to prevent people from using older legacy protocols like POP. However, your CEO is still using an old laptop/software. What are your options? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/conditional-access/block-legacy-authentication)

## Identity protection ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/7-design-for-identity-protection))

1. What's the difference between sign-in risk and user risk? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/identity-protection/howto-identity-protection-configure-risk-policies)
2. What are some common examples of sign-in risk and user risk? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/identity-protection/concept-identity-protection-risks)
3. What should you do to enable break-the-glass/emergency access account? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/roles/security-emergency-access)

## Access reviews ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/8-design-for-access-reviews))

1. What is an access review and why should you use it? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/governance/access-reviews-overview) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/governance/manage-access-review) [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/governance/deploy-access-reviews)
2. What problem is it trying to solve? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/governance/access-reviews-overview#when-should-you-use-access-reviews)
3. What license do you require? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/governance/access-reviews-overview#license-requirements)
4. Who can conduct a review during an access review? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/governance/manage-access-review#create-and-perform-an-access-review-for-users)

## Service principals for applications ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/9-design-service-principles))

![whiteboard](/whiteboards/07-service-principals.png)

1. What is a managed identity and what is it trying to solve? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/managed-identities-azure-resources/overview)
2. What is the difference between a user assigned identity and a system managed identity? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/managed-identities-azure-resources/overview#managed-identity-types)
3. What is the Azure Instance Metadata Service, and why is it important in the context of managed identity? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/managed-identities-azure-resources/how-managed-identities-work-vm) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-machines/windows/instance-metadata-service?tabs=windows)
4. What is a service principal? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/develop/app-objects-and-service-principals)
5. Can you explain the relationship between application objects and service principals? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/develop/app-objects-and-service-principals#relationship-between-application-objects-and-service-principals)
6. Microsoft identity platform supports two types of permissions - delegated permissions and application permissions. What is used when? [[doc]](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-permissions-and-consent#permission-types)

## Azure key vault ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-authentication-authorization-solutions/10-design-for-azure-key-vault))

1. Why use Azure Key Vault? [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/general/overview#why-use-azure-key-vault)
2. How many Azure Key Vaults do you require for your applications? [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/general/best-practices)
3. What is the difference between a key and a secret in Azure Key Vault? [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/keys/about-keys) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/keys/about-keys-details) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/secrets/about-secrets)
4. What is the difference between a key and a certificate in Azure Key vault? [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/keys/about-keys) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/keys/about-keys-details) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/certificates/about-certificates)
5. Azure Key Vault has two service tiers - Standard and Premium. Why would you choose one over the other? [[doc]](https://azure.microsoft.com/en-us/pricing/details/key-vault/) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/managed-hsm/overview)
6. How can you authenticate against Azure Key Vault? (2 supported modes) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/general/assign-access-policy?tabs=azure-portal) [[doc]](https://docs.microsoft.com/en-us/azure/key-vault/general/rbac-guide?tabs=azure-cli)

# 08 - Design a solution to log and monitor Azure resources ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/))

## Azure Monitor ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/2-design-for-azure-monitor-data-sources))

1. Azure Monitor collects data automatically from a range of components. Can you share some examples/use cases?
2. Example - you have experienced recently an Azure Storage Account Key leakage. How can you prevent this in future?

## Log Analytics ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/3-design-for-log-analytics))

1. How many Log Analytics resources do you need?
2. Would you go for a centralized or decentralized approach? Hybrid?
3. What do you pay for?
4. What is the retention time for log data that has been ingested. Can you change this?
5. How can you integrate logging data from Virtual Machines?
6. What can you do to create a dashboard targeted towards business users, showing them some relevant metrics?
7. You want to prevent users from accessing certain data in you Log Analytics workspace. Is this possible and how?
8. Does Log Analytics have some rate limits applicable?
9. How do you enforce capturing logging from your Azure resources into Log Analytics?

## Azure workbooks and Azure Insights ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/4-design-for-azure-workbooks-insights))

1. What are Azure Workbooks?
2. Why would you consider to implement an Azure Workbook?
3. What is Azure Application Insights and what does it offer on top of Log Analytics?
4. What can you use the monitor your Azure Kubernetes environment?

## Azure Data Explorer ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-to-log-monitor-azure-resources/5-design-for-azure-data-explorer))

1. What is Azure Data Explorer?
2. What do you pay for?

# 09 - Design a network infrastructure solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/))

## Recommend a network architecture solution based on workload requirements ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/2-recommend-network-architecture-solution-based-workload-requirements))

1. Why would you want to create multiple virtual networks, or create multiple subnets in your VNET? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/reference-architectures/hybrid-networking/network-level-segmentation) [[doc]](https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-vnet-plan-design-arm)
2. Why does it matter to apply a naming convention when creating virtual networks? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/ready/azure-best-practices/resource-naming#example-names-networking)
3. Can you deploy resources across multiple regions in the same virtual network?
4. How large should your virtual network's address space be?
    - Why is important that virtual network address ranges do not overlap?
5. What is the difference between a network virtual appliance (NVA) like a Firewall and a NSG Network Security Group?
6. What is a hub and spoke topology and why would you consider it? What are the benefits/disadvantages?
    - What resources should become part of your hub, and what would you deploy into your spokes?
    - Should you allow spokes to communicate with each other directly? Why?

## Design for on-premises connectivity to Azure virtual networks ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/3-design-for-premises-connectivity-to-azure-virtual-networks))

1. Which Azure VPN Gateway SKU should you implement and why?
2. What is the SLA offered by VPN Gateway and what is/is not included? How can you increase the SLA?
3. Is traffic encrypted over the VPN Gateway?
4. What can you do to troubleshoot your VPN connection?
5. Why would you consider an Express Route?
6. Can you use an Express route and combine it with a VPN Gateway? Why would you do this?
7. What advantage brings Azure Virtual WAN to the table?

## Design for Azure network connectivity services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/4-design-for-azure-network-connectivity-services))

1. When setting up peering between 2 virtual networks, is traffic encrypted?
2. What do you pay for when using VNET Peering?
3. Why would you consider implementing Virtual Network NAT (Network Address Translation)?
4. Why would you consider overriding Azure's default routing? How do you accomplish this?

## Design for application delivery services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/5-design-for-application-delivery-services))

1. Why would you consider to use an Azure CDN Content Delivery Network. What problem does it solve?
2. What possible sources should you consider for Azure CDN?
3. What would you pay for and how does it compare to other services like Azure App Service?
4. What are the differences between Load Balancer, Traffic Manager, Application Gateway and Front Door?

## Design for application protection services ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-network-solutions/6-design-for-application-protection-services)))

1. Why would you want to go for Azure DDoS protection Standard instead of the default one?
2. What would you pay for when using this service?
3. What problem is it that Azure Private Link is trying to solve?
4. Should you consider Azure Firewall or go for any other 3rd party firewall technology?
5. What are the advantages and disadvantages of setting up Service Endpoints?
6. What's the difference between Network Security Groups and Application Security Groups
7. What problem is it that Azure Bastion solves?
8. How can you implement Just in Time Access?

# 10 - Design a business continuity solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/))

## Backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/2-design-recovery))

1. What is the difference between RTO and RPO? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/manage/considerations/protect) [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/business-continuity-high-availability-disaster-recover-hadr-overview) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/framework/resiliency/business-metrics)
2. What are SLA's and why does it matter? Who provides the SLA? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/manage/considerations/impact) [[doc]](https://azure.microsoft.com/en-us/support/legal/sla/)
3. How would you calculate the SLA? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/framework/resiliency/business-metrics#understand-service-level-agreements)
4. What is MTBF and MTTR and what would be appropriate values?
5. How do you know that a service/application does (not) reach it's SLA? [[doc]](https://docs.microsoft.com/en-us/azure/architecture/framework/devops/checklist) [[doc]](https://docs.microsoft.com/en-us/azure/architecture/example-scenario/monitoring/enterprise-monitoring) [[doc]](https://docs.microsoft.com/en-us/azure/azure-monitor/app/availability-overview)
6. Why do you need both disaster recovery and backup? [[doc]](https://docs.microsoft.com/en-us/learn/modules/describe-high-availability-disaster-recovery-strategies/3-explore-high-availability-disaster-recovery-options)
7. Why would you test your disaster recovery?

## Azure Backup ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/3-design-for-azure-backup))

1. What can you backup with Azure Backup? [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-support-matrix)
2. What do you pay for? [[doc]](https://azure.microsoft.com/en-us/pricing/details/backup/)
3. How much data can you store and for how long? [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-azure-vm-backup-faq) [[doc]](https://docs.microsoft.com/en-us/azure/backup/archive-tier-support)
4. What does it mean to have application consistent backups?
5. Can you backup SQL databases with it? [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-azure-sql-database)
6. Does it store backups also across regions? Only the region pair or other regions? [[doc]](https://docs.microsoft.com/en-us/azure/backup/guidance-best-practices)
7. Why is it important to protect your Azure Backup? How can you accomplish this? [[doc]](https://docs.microsoft.com/en-us/azure/backup/guidance-best-practices#security-considerations)

## Azure blob backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/4-design-for-azure-blob-backup-recovery))

1. What are the features you can use with Azure Blob storage to be able to recover data without Azure Backup? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/data-protection-overview)
2. Can you perform a Point-in-time restore on Azure Blob storage? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/point-in-time-restore-overview)
3. Can you use Azure Backup to backup Azure Blob storage? Why would you use/not use this?
4. Can you recover a deleted Azure Storage account? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-account-recover)
5. How many years can you configure immutable storage? [[doc]](https://docs.microsoft.com/en-us/azure/storage/blobs/immutable-storage-overview) [[doc]](https://www.rijksmuseum.nl/nl/collectie/SK-A-1699)

## Azure Files backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/5-design-for-azure-files-backup-recovery))

1. What are Azure Files snapshots?
2. How would you automate file share backups?
3. Why should you configure alerting and reporting provided by Azure Backup? [[doc]](https://docs.microsoft.com/en-us/azure/backup/monitoring-and-alerts-overview) [[doc]](https://docs.microsoft.com/en-us/azure/backup/backup-afs)
4. Why would you want to perform an on-demand backup of a file share if it is also scheduled? [[doc]](https://docs.microsoft.com/en-us/azure/backup/manage-recovery-points)

## Azure virtual machine backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/6-design-for-azure-virtual-machine-backup-recovery))

1. What is the difference between snapshot tier and vault tier?

## Azure SQL backup and recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/7-design-for-azure-sql-backup-recovery))

1. How does Azure SQL perform backups and what's the interval, RPO and RTO? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/automated-backups-overview?tabs=single-database)
2. What happens in case a region goes down? Can I restore to another region and who is responsible for this? [[doc]](https://docs.microsoft.com/en-us/azure/azure-sql/database/business-continuity-high-availability-disaster-recover-hadr-overview)

## Azure Site Recovery ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-solution-for-backup-disaster-recovery/8-design-for-azure-site-recover))

1. Why would you choose Azure Site Recovery over another (3rd-party) solution?
2. Why would you combine Azure Site Recovery with Azure Backup?

# 11 - Design a migration solution ([Learn module](https://docs.microsoft.com/en-us/learn/modules/design-migrations/))

## Evaluate migration with the Cloud Adoption Framework ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/2-evaluate-migration-cloud-adoption-framework))

1. Why would you consider migrating to Azure? [[doc]](https://docs.microsoft.com/en-us/azure/migrate/concepts-migration-planning#define-cloud-migration-goals)
2. What is the Microsoft Cloud Adoption Framework for Azure?
3. Why should I use/not use this when considering a migration?

## Describe the Azure Migration Framework ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/3-describe-azure-migration-framework))

1. What are the 4 stages in the Azure Migration Framework?
    - What happens during each of these stages?
2. Which strategy should you take when considering a migration?
3. What is the difference between refactoring and rearchitecting?

## Assess your workloads ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/4-assess-your-premises-workloads))

1. Why would you consider Azure TCO Calculator?
2. What kind of activities should be performed during the assesment phase?
3. What is an Azure Migrate Project?
4. What is the expected outcome of an Azure Migrate assesment?
5. Why would you use DMA (Data Migration Assistant) and DMS (Data Migration Service)?
6. Imagine you have 1000's of VM's to migrate. You want to take a phased approach and not migrate everything at once, but rather workload by workload. What tool would you use during the assement so you know the dependencies between machines?
7. Why do I need to download an appliance in my Hyper-V/VMWare environment? [[doc]](https://docs.microsoft.com/en-us/azure/migrate/migrate-appliance)
8. What is the difference between agentless/agent-based dependency analysis? [[doc]](https://docs.microsoft.com/en-us/azure/migrate/how-to-create-group-machine-dependencies) [[doc]](https://docs.microsoft.com/en-us/azure/migrate/how-to-create-group-machine-dependencies-agentless)
9. I don't want to use an appliance. What are my options? [[doc]](https://docs.microsoft.com/en-us/azure/migrate/tutorial-discover-import)
10. Why does it make sense to keep the assement tool running for a longer period of time? [[doc]](https://docs.microsoft.com/en-us/azure/migrate/how-to-create-assessment) [[doc]](https://docs.microsoft.com/en-us/azure/migrate/how-to-modify-assessment)

## Compare migration tools ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/5-select-migration-tool))

1. What tools should I consider to migrate a workload to Azure? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/migrate/azure-migration-guide/migrate?tabs=Tools)
2. What can you do with Azure Migrate (scenarios)? [[doc]](https://docs.microsoft.com/en-us/azure/cloud-adoption-framework/scenarios/)
3. What is the Azure App Service Migration Assistant? [[doc]](https://github.com/Azure/App-Service-Migration-Assistant/wiki) [[doc]](https://docs.microsoft.com/en-us/learn/modules/migrate-app-service-migration-assistant/)
4. What is the Azure Resource Mover? [[doc]](https://docs.microsoft.com/en-us/azure/resource-mover/overview)

## Migrate your databases ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/6-migrate-your-databases))

1. What is the Azure Database Migration Service? [[doc]](https://docs.microsoft.com/en-us/azure/dms/dms-overview)
2. Can you perform online migration with minimal downtime? [[doc]](https://docs.microsoft.com/en-us/azure/dms/resource-scenario-status#online-continuous-sync-migration-support)
3. Which prerequisites need to be in place before you can perform an online/offline migration? [[doc]](https://docs.microsoft.com/en-us/azure/dms/pre-reqs)
4. Which tool would you use to migrate the database schema? [[doc]](https://docs.microsoft.com/en-us/sql/dma/dma-overview?view=sql-server-ver15)
5. Which tool would you use to migrate the data? [[doc]](https://docs.microsoft.com/en-us/azure/dms/dms-overview)

## Select an online storage migration tool ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/7-select-online-storage-migration-tool))

1. When would you use the Windows Storage Migration Service? [[doc]](https://docs.microsoft.com/en-us/windows-server/storage/storage-migration-service/overview#why-use-storage-migration-service)
2. When would you use Azure File Sync? [[doc]](https://docs.microsoft.com/en-us/azure/storage/files/storage-files-migration-overview?toc=/azure/storage/filesync/toc.json)

## Select an offline storage migration tool ([Unit](https://docs.microsoft.com/en-us/learn/modules/design-migrations/8-migrate-offline-data))

1. When would you use the Azure Import/Export service? [[doc]](https://docs.microsoft.com/en-us/azure/import-export/storage-import-export-service)
2. When would you use Data Box? [[doc]](https://docs.microsoft.com/en-us/azure/databox/data-box-overview)
3. What other tools can you use to import/export moderate volumes of data? [[doc]](https://docs.microsoft.com/en-us/azure/storage/common/storage-use-azcopy-v10)

