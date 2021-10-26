<?php

class PostModel extends Database
{
    protected $db;

    public function __construct()
    {
        $this->db = new Database();
        $this->db->connect();
    }

    public function addPost($title, $slug, $summary, $content, $categoryId, $userId, $date)
    {
        $title = $this->db->conn->real_escape_string($title);
        $slug = $this->db->conn->real_escape_string($slug);
        $summary = $this->db->conn->real_escape_string($summary);
        $content = $this->db->conn->real_escape_string($content);
        $sql = "INSERT INTO posts (title, slug, summary, content, category_id, user_id, date)
							VALUES ('$title', '$slug', '$summary', '$content', '$categoryId', '$userId', '$date')";

        return $this->db->conn->query($sql);
    }
    
    public function deletePost($postId)
    {
        $sql = "DELETE FROM posts WHERE id = $postId";

        return $this->db->conn->query($sql);
    }
}
