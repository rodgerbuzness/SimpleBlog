﻿using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Migrations
{
    [Migration(3)]
    public class _003_AddContentPosts : Migration
    {
        public override void Down()
        {
            Delete.Column("content").FromTable("posts");
        } 

        public override void Up()
        {
            Create.Column("content").OnTable("posts").AsCustom("TEXT");
        }
    }
}