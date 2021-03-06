﻿Feature: UT006 Generate File with global header
	As a developer
	I can generate code with t4 and a global custom header

Scenario: Generate multiple files with global header
	Given the file manager
	And the script "TestGlobalHeader.tt" with following content for automation
		"""
<#@ template debug="false" hostspecific="true" language="C#" #>
<#@ assembly name="System.Core" #>
<#@ import namespace="System.Linq" #>
<#@ import namespace="System.Text" #>
<#@ import namespace="System.Collections.Generic" #>
<#@ output extension=".txt" #>

<#@ include file="$(ProjectDir)\T4.FileManager.VisualStudio.ttinclude" #>

<#
var fileManager = new T4FileManager(this.GenerationEnvironment, this.Host);
fileManager.StartHeader();
#>
// -------------------------
// databinding - T4
// -------------------------
<#
fileManager.FinishHeader();
fileManager.CreateNewFile("PersonDtoWithGlobal.g.cs","","",null);	
#>
namespace Test
{
	public class PersonDtoWithGlobal
	{
	}
}
<#
fileManager.CreateNewFile("OrderDtoWithGlobal.g.cs","","",null);	
#>
namespace Test
{
	public class OrderDtoWithGlobal
	{
	}
}
<#
fileManager.Generate();
#>
		"""
	When i run the script for automation
	Then following files are generated:
		| File           |
		| PersonDtoWithGlobal.g.cs |
		| OrderDtoWithGlobal.g.cs  |
	And all files contains following content:
		"""
// -------------------------
// databinding - T4
// -------------------------
		"""