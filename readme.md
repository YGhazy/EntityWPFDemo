#Code first with existing db
add ado.net with add connection string and select db and its tables
enable-migrations
add-migration initialModel -IgnoreChanges -Force   // empty migrations
update-database
ignore-migrations  // already exit in db
