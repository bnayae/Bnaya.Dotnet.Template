# Setup

- Replace TEMPLATE_NAME, TEMPLATE_SHORT_NAME,PROJECT_DEFAULT_NAME, GIT_HUB_USER, AUTOR, TEMPLATE_TITLE  with the name of your template 
  - Bnaya.Dotnet.Template.csproj
  - templates/Skeleton/template.json
  - ReadMe.md
- Replace AUTOR with the name of your template (templates/Skeleton/template.json)
- Take a look at the license and change it if needed
- Replace the Icon

## CLI

```bash
dotnet new TEMPLATE_SHORT_NAME -n Company.HelloWorld
dotnet new TEMPLATE_SHORT_NAME -n Company.HelloWorld --user git-user --email someone@somewhere.com --enable-ci --version net7.0
dotnet new TEMPLATE_SHORT_NAME -n Company.HelloWorld -u git-user -e someone@somewhere.com -ci -v  net7.0

```

```bash
# dotnet build --force
dotnet pack -c Release --force -o .
# dotnet new install . 
dotnet new install TEMPLATE_NAME
dotnet new TEMPLATE_SHORT_NAME -h
dotnet new TEMPLATE_SHORT_NAME -n {name-of-the-project}
# dotnet new uninstall {name-of-the-project}
# dotnet new uninstall .
dotnet new uninstall TEMPLATE_NAME
```



# Creating a custom .NET CLI template

- [.NET SDK](https://github.com/dotnet/sdk/)
- [ASP.NET Core Template](https://github.com/dotnet/aspnetcore/blob/main/src/ProjectTemplates/Web.ProjectTemplates/content/WebApi-CSharp/.template.config/template.json)
- [Video Tutorial](https://www.google.com/search?q=Custom+templates+for+dotnet+new&oq=Custom+templates+for+dotnet+new&aqs=chrome..69i57j69i60.581j0j4&sourceid=chrome&ie=UTF-8#fpstate=ive&vld=cid:a6dbe0e2,vid:rdWZo5PD9Ek)*
- [Custom templates for dotnet new](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates)
- [Tutorial: Create an item template](https://learn.microsoft.com/en-us/dotnet/core/tutorials/cli-templates-create-item-template)
- [WiKi](https://github.com/dotnet/templating/wiki)
- [Samples](https://github.com/dotnet/dotnet-template-samples)
- [Available Symbols Generators](https://github.com/dotnet/templating/wiki/Available-Symbols-Generators)

## NuGet

- [Install as NuGet](https://learn.microsoft.com/en-us/dotnet/core/tools/custom-templates#install-a-template-package)


## Attribution

### Icon

- [Templates icons created by Freepik - Flaticon](https://www.flaticon.com/free-icons/templates)
