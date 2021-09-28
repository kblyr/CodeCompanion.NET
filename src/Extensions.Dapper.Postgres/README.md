# Extensions.Dapper.Postgres

This library currently only provides ability to query refcursors, this imitates the QueryMultiple, since PostgreSQL don't support multiple result set, we're using the Refcursor feature of the database.