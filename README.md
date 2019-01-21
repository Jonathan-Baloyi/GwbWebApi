
Database migrations are done using Entity Framework Migrations (currently only supported via package manager console commands or the .Net CLI)

Naming Conventions
For consistency we should name the first migration InitialCreate and the first data seed migration should be called InitializeData.

Create New/Initial Migration
In a Package Manager console, select the new project and run the following command:
Add-Migration InitialCreate -o <Output Directory - for default use Data\Migrations>

Example generating for the Companies service:
Add-Migration InitialCreate -o Data\Migrations

Create First Data Seed Migration
First make sure that your project has been built and run the InitialCreate migration.
In a Package Manager console, select the roject and run the following command:
Add-Migration InitializeData -o <Output Directory - for default use Data\Migrations>

Example generating for the Companies service:
Add-Migration InitializeData -o Data\Migrations

Once the new migrations has been generated you should add a class to setup the initial data (such as a class named SetupInitialData) and call the initialize data methods on that class from the generated InitializeData migration.

Adding More Migrations
Add-Migration <Migration-Name>
Note: You don't need to specify the Migration folder again if it was setup correctly on the creation of the first migration

Authentication Service Migrations
There are 3 different DbContexts that we need to create migrations for. They can be created with the following commands:
Add-Migration <migration-name> -o Data\Migrations\Authentication -c AuthenticationDbContext
Add-Migration <migration-name> -o Data\Migrations\Configuration -c ConfigurationDbContext
Add-Migration <migration-name> -o Data\Migrations\PersistedGrant -c PersistedGrantDbContext

**Edit a file, create a new file, and clone from Bitbucket in under 2 minutes**

When you're done, you can delete the content in this README and update the file with details for others getting started with your repository.

*We recommend that you open this README in another tab as you perform the tasks below. You can [watch our video](https://youtu.be/0ocf7u76WSo) for a full demo of all the steps in this tutorial. Open the video in a new tab to avoid leaving Bitbucket.*

---

## Edit a file

You’ll start by editing this README file to learn how to edit a file in Bitbucket.

1. Click **Source** on the left side.
2. Click the README.md link from the list of files.
3. Click the **Edit** button.
4. Delete the following text: *Delete this line to make a change to the README from Bitbucket.*
5. After making your change, click **Commit** and then **Commit** again in the dialog. The commit page will open and you’ll see the change you just made.
6. Go back to the **Source** page.

---

## Create a file

Next, you’ll add a new file to this repository.

1. Click the **New file** button at the top of the **Source** page.
2. Give the file a filename of **contributors.txt**.
3. Enter your name in the empty file space.
4. Click **Commit** and then **Commit** again in the dialog.
5. Go back to the **Source** page.

Before you move on, go ahead and explore the repository. You've already seen the **Source** page, but check out the **Commits**, **Branches**, and **Settings** pages.

---

## Clone a repository

Use these steps to clone from SourceTree, our client for using the repository command-line free. Cloning allows you to work on your files locally. If you don't yet have SourceTree, [download and install first](https://www.sourcetreeapp.com/). If you prefer to clone from the command line, see [Clone a repository](https://confluence.atlassian.com/x/4whODQ).

1. You’ll see the clone button under the **Source** heading. Click that button.
2. Now click **Check out in SourceTree**. You may need to create a SourceTree account or log in.
3. When you see the **Clone New** dialog in SourceTree, update the destination path and name if you’d like to and then click **Clone**.
4. Open the directory you just created to see your repository’s files.

Now that you're more familiar with your Bitbucket repository, go ahead and add a new file locally. You can [push your change back to Bitbucket with SourceTree](https://confluence.atlassian.com/x/iqyBMg), or you can [add, commit,](https://confluence.atlassian.com/x/8QhODQ) and [push from the command line](https://confluence.atlassian.com/x/NQ0zDQ).