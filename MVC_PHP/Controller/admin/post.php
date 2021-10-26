public function postList()
{
$sql = "SELECT * FROM posts";
$result = $this->db->conn->query($sql);
$list = array();
while ($data = $result->fetch_array()) {
$list[] = $data;
}

return $list;
}