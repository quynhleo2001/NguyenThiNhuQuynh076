Namespace NguyenThiNhuQuynh076.Controllers
{
    public class CompanyNTNQ076Controller : Controller
    {
          private readonly ApplicationDbContext _context;

        public CompanyNTNQ076Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChucVu
        public async Task<IActionResult> Index()
        {
              return _context.CompanyNTNQ076 != null ? 
                          View(await _context.CompanyNTNQ076.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CompanyNTNQ076'  is null.");
        }
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName")] CompanyNTNQ076 companyNTNQ076)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNTNQ076);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNTNQ076);
        }
         public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyID == null)
            {
                return NotFound();
            }

            var companyID = await _context.companyID
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (companyID == null)
            {
                return NotFound();
            }

            return View(companyID);

    }
}
