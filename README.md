Azure Data Center Migration Solution (adcms)
============================================

##Introduction
To ease migrations, Persistent Systems, along with the Microsoft Customer Advisory Team, has developed the open source Azure Data Center Migration Solution for automatically copying an entire infrastructure as a service (IaaS) deployment on Azure from one location to another. 

With the Azure Data Center Migration Solution version 1.0, you can automate the migration of Microsoft Azure resources:

* From one subscription to another subscription in the same data center (region).
* From one subscription to another subscription in different data centers.
* In the same subscription with different data centers.
* In the same subscription with the same data center.

You can migrate all of the following resources in the source data center:

* Affinity groups
* Networks
* Cloud services
* Storage accounts 
* Virtual machines (VMs)

##User Guide
Please refer to the [User Guide](/User%20Guide.docx?raw=true) for instructions on how the use the solution.
It also describes the solution architecture and how the solution takes care of important considerations like atomicity, consistency and extensibity.
You can also take a look at [this video](/videos/adcms_v1.0_demo.mp4?raw=true) to see a working demo of the solution.

##Contributors

###Persistent Systems: 
Satish Nikam, Maryann Fernandes, Shubhangi Pote, Neelam Sahu, Divya M

###Microsoft: 
Rangarajan Srirangam, Guy Bowerman, Suren Machiraju, Yohirito Tada

##License
The content of this repository is licensed under the Apache License, Version 2.0. Please find a copy of the license [here](/License.txt).

##Issues / Feedback
You may report issues or submit feature requests in the [Issues](https://github.com/persistentsystems/adcms/issues) section of this repository. 
For questions or feedback about the solution, please contact [adcms@persistent.com](mailto:adcms@persistent.com).

##FAQs

1.	I don't want to migrate all the resources from my source data center. Is there a way to select resources for migration?

    At this time, the solution does not provide a way to choose which resources to export or import. A workaround to achieve this is to:

	-	Export the source data center to the metadata JSON file
	-	Modify it to remove resources that should not be copied to the destination
	-	Use the edited file during the Import process

	The metadata file contains all VM dependent resources like VMs/affinity groups/cloud services/storage accounts/virtual networks. If your source data center contains extra resources, you can choose not to import them by removing them from the exported JSON file. While editing the JSON file, you need to be careful that you don’t miss the dependent resources of the VMs you want to migrate. E.g. If the virtual machine is present within affinity group or in a virtual network, all the dependent resources i.e. cloud service in which the VM is located, storage account where the blobs are stored, affinity group and virtual network if applicable should be present in the metadata file.