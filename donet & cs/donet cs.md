## Web application
### Donet c#

#### Authetication
    <html>
    - Database
    - User account

    1. Use ORM (Entity Framework)
    2. Create database manually
    </html>

#### MVC
    <html>
    - Right click model > add > class 
    class will have properties

    - Model: manges behavior and data
    Model > Class > type prop tab tab to give property and ctor tab tab for constructor

    - View: manages the display of data

    - Controller: handles page events and navigation between pages
    right click controller > add > controller > mvc with views using entity framework > select created model > new module and 5 new webpages created

    - Data migrations

    - Package manager console: add-migration "anystringname" > generate anystringname setup.cs (create table) > update-database (ORM will create 2 tables user account and createdmodel.cs)

    </html>

#### HomeController
    <html>
    - Click on Index link will send to user

      public IActionResult Index()
        {
            return View();
        }
    </html>


#### Created model controller
       // Index: items will display all list
       // Inside {code} created using entity framework

        // GET: List
        public async Task<IActionResult> Index()
        {
            return View(await _context.List.ToListAsync());
        }

#### View
    <html>
    - Html & css code
    - Get a list of data from controller
    - Combines data with html in template
    - razor (asp.net)

    </html>

#### Model
    <html>
    - Data 
    - Consists of classes/objects
    - SQL
    - Supplies the controller with list of objects

    </html>

#### Layout
    <html>
    - Refer to <nav class="navbar and created model controller

    <li class="nav-item">
        <a class="nav-link text-dark" asp-area="" asp-controller="Created model controller title" asp-action="Index">nav bar title</a>
    </li>
     

    </html>

#### Create new link (etc. search)
    <html>

    - layout

    <li class="nav-item">
        <a class="nav-link text-dark" asp-area="" asp-controller="Created model controller title" asp-action="Index">nav bar title</a>
    </li>

    - ListController (link)

    // GET: List/DisplaySearch
    public async Task<IActionResult> DisplaySearch()
    {
        return View();
    }

    - Create another named as "DisplaySearch" search page and place under List model

    - Display search all result in database
    - looking for index view, following data
        return View(await _context.List.ToListAsync());
    
    - Filter by inserting Where() with user input as (SearchPhrase)
    // PoST: List/DisplaySearch
    public async Task<IActionResult> DisplaySearchResults(String SearchPhrase)
    {
        return View("Index", await _context.List.Where( j => j.Todo.Contains(SearchPhrase)).ToListAsync());
     
    }

    </html>

#### AUthorization
    <html>
    - ListController: enter [Authorize] into edit, delete, delete confirm, httppost
    - Avoid input data by inserting [Authorize]
    - Will auto import: using Microsoft.AspNetCore.Authorization;

    [Authorize]
        // GET: List/Create
        public IActionResult Create()
        {
            return View();
        }

    [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Todo")] List list)

    </html>

#### www.root
    <html>
    - site.css, site.js to customise website

    </html>
